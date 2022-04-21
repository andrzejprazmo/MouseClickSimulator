namespace MouseClickSimulator
{
    using System;

    public class Synchronizer
    {
        public static int Synchronize(string timeServer)
        {
            NTPClient client;
            try
            {
                client = new NTPClient(timeServer);
                client.Connect(true);
            }
            catch (Exception e)
            {
                return -1;
            }
            return 0;
        }
    }
}
