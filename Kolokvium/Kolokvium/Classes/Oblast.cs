using System;
namespace Kolokvium.Classes
{
    public class Oblast
    {
        private string Name;
        private int Index;

        public string GetNameOfOblast() { return Name; }
        public int GetIndexOfOblast() { return Index; }

        public void SetNameOfOblast(string Name) { this.Name = Name; }
        public void SetIndexOfOblast(int Index) { this.Index = Index; }

        public Oblast()
        {
        }
    }
}
