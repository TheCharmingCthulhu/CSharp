namespace Designer.Source
{
    class Matrix
    {
        int[,,] _data;
        
        public int this[int z, int x, int y]
        {
            get
            {
                return _data[z, x, y];
            }

            set
            {
                _data[z, x, y] = value;
            }
        }

        public Matrix(int z, int x, int y)
        {
            _data = new int[z, x, y];
        }
    }
}
