using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sandbox.Sources.Sequences
{
    class SequenceManager
    {
        public List<CustomItems> Items { get; set; } = new List<CustomItems>();

        public SequenceManager()
        {
#if DEBUG
            Sample(12 * 60 * 60 * 1000);
#endif
        }

        private void Sample(int duration)
        {
            for (int i = 0; i < 5; i++)
            {
                var items = new List<CustomItems.CustomItem>();

                for(int j = 0; j < 4; j++)
                {
                    items.Add(new CustomItems.CustomItem()
                    {
                        Duration = j % 3 == 0 ? 4000 : 8000,
                        Type = j % 3 == 0 ? 0 : 1
                    });
                }

                items.Add(new CustomItems.CustomItem()
                {
                    Duration = 2000,
                    Type = 0
                });

                Items.Add(new CustomItems()
                {
                    Items = items
                });
            }
        }

        internal List<Sequence> ParseItems(double duration)
        {
            var sequences = new List<Sequence>();

            double interval = 1000;
            double time = 0;

            int nextTimeOne = 0;
            CustomItems.CustomItem nextItemOne = null;
            int nextTimeTwo = 0;
            CustomItems.CustomItem nextItemTwo = null;

            do
            {
                var sequence = new Sequence() { Duration = (int)interval };

                foreach (var CustomItems in Items)
                {
                    ParseSequence(0, CustomItems, sequence, time, ref nextTimeOne, ref nextItemOne);
                    ParseSequence(1, CustomItems, sequence, time, ref nextTimeTwo, ref nextItemTwo);
                }

                sequences.Add(sequence);

                time += interval;
            } while (time < duration);

            return sequences;
        }

        private void ParseSequence(int type, CustomItems customItems, Sequence sequence, double time, ref int nextTime, ref CustomItems.CustomItem nextItem)
        {
            for (int i = 0; i < customItems.Items.Count; i++)
            {
                if (customItems.Items[i].Type == type && time == nextTime)
                {
                    if (nextItem != null && customItems.Items[i] != nextItem) continue;

                    sequence.Items.Add(customItems.Items[i]);

                    nextTime += customItems.Items[i].Duration;

                    nextItem = customItems.Items.Skip(i + 1).FirstOrDefault(item => item.Type == type);
                }
            }
        }

        internal string OutputXML(List<Sequence> sequences)
        {
            var xml = new StringBuilder();

            using (var writer = XmlWriter.Create(xml, new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("sequences");

                foreach (var sequence in sequences)
                {
                    writer.WriteStartElement("sequence");
                    writer.WriteAttributeString("interval", sequence.Duration.ToString());

                    foreach (var customItem in sequence.Items)
                    {
                        writer.WriteStartElement("item");
                        writer.WriteAttributeString("type", customItem.Type.ToString());
                        writer.WriteValue(customItem.Duration.ToString());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            return xml.ToString();
        }
    }
}
