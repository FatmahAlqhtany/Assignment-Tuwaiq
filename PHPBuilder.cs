using System;

namespace Builder
{
    class PHPBuilder
    {
        private string PHP;
        public PHPBuilder()
        {
            this.PHP = "";
        }
        public PHPBuilder StartWith()
        {
            this.PHP += "<?PHP ";

            return this;
        }
        public PHPBuilder content(string va)
        {
            this.PHP += va;
            return this;
        }
        public PHPBuilder Endwith()
        {
            this.PHP +="?>";
            return this;
        }
        public string get()
        {
            return this.PHP;
        }

        static void Main(string[] args)
        {
            PHPBuilder ThePHP = new PHPBuilder();
            string PHPcode = ThePHP.StartWith()
                .content("$number = 100 ")
                .Endwith().get();
            Console.WriteLine(PHPcode);
        }
    }
}
