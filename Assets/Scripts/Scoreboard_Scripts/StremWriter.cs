using System.IO;

namespace Sno.Scoreboards
{
    internal class StremWriter : StreamWriter
    {
        private object s;

        public StremWriter(object s)
        {
            this.s = s;
        }
    }
}