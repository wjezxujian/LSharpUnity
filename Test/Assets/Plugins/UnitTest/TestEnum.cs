public enum CSharpEnum : byte
    {
        Zero = 0,
        One = 1,
        Two = 2,
    }

    public struct MyTestClassA
    {
        CSharpEnum data;
        public MyTestClassA(CSharpEnum data)
        {
            this.data = data;
        }
    }
