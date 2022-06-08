namespace CSClass
{
    class SingleTon
    {
        private static SingleTon instance = null;

        public SingleTon()
        {

        }

        public static SingleTon getInstance()
        {
            if(instance == null)
            {
                instance = new SingleTon();
            }
            return instance;
        }
    }
}