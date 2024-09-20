using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; private set; }
        public List<Shark> Species { get; private set; }
        public int GetCount => Species.Count;

        public void AddShark(Shark shark)
        {
            {
                if (GetCount < Capacity)
                {
                    if (!Species.Any(s => s.Kind == shark.Kind))
                    {
                        Species.Add(shark);
                    }

                }
            }
        }

        public bool RemoveShark(string kind)
            => Species.Remove(Species.FirstOrDefault(s => s.Kind == kind));



        //public Shark GetLargestShark() => Species.MaxBy(s => s.Length);
        public string GetLargestShark() => Species.MaxBy(s => s.Length).ToString();
        //•	Method GetLargestShark()– returns the ToString() value of the largest of all sharks, arranged by length.


        public double GetAverageLength() => Species.Average(s => s.Length);

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetCount} sharks classified:");

            foreach (var shark in Species)
            {
                sb.AppendLine(shark.ToString());
            }

            return sb.ToString().TrimEnd();

        }




    }
}
