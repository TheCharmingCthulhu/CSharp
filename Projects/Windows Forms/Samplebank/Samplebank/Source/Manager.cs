using Samplebank.Source.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Samplebank.Source
{
    class Manager
    {
        public static ObservableCollection<Sample> Samples { get; private set; } = new ObservableCollection<Sample>();

        public static List<Sample> QuerySamples()
        {
            Samples.Clear();

            //var reader = Program.Database.Execute(string.Format("SELECT * FROM {0}", Types.APP_TABLE_SAMPLES));

            //while (reader.Read())
            //{
            //    var sample = new Sample(reader.GetInt32(0))
            //    {
            //        Name = reader.GetString(1),
            //        Size = reader.GetInt32(2),
            //        Duration = TimeSpan.FromSeconds(reader.GetDouble(3)),
            //        Hash = reader.GetString(4),
            //        Source = reader.GetString(5),
            //        Path = reader.GetString(6)
            //    };

            //    Samples.Add(sample);
            //}

            //reader.Close();

            return null;
        }

        public static void AddSamples(string[] paths)
        {
            Samples.Clear();

            foreach (var path in paths)
                Samples.Add(new Sample(path));
        }

        public static void CommitSamples()
        {
            lock (Samples) {
                //foreach (var sample in Samples)
                //    Program.Database.Tables[Types.DATABASE_TABLE_SAMPLES].Insert(sample);
                    //Program.Database.Insert(Types.DATABASE_TABLE_SAMPLES, sample);
            }
        }

        public static void DeleteSample(Sample sample)
        {
            //Program.Database.Delete(Types.APP_TABLE_SAMPLES, Tuple.Create("id", sample.ID.ToString()));
        }
    }
}
