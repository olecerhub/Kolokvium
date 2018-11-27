using System;
namespace Kolokvium.Classes
{
    public class HumanSettlement : Oblast
    {
        private string Name;
        private string Emblem;
        private int Index;

        public string GetNameOfHS() { return Name; }
        public string GetEmblem() { return Emblem; }
        public int GetIndexOfHS() { return Index; }

        public void SetNameOfHS (string Name) { this.Name = Name; }
        public void SetEmblem (string EmblemLink) { Emblem = EmblemLink; }
        public void SetIndexOfHS(int Index) { this.Index = Index; }


        public HumanSettlement()
        {
        }
    }
}
