namespace StackTest {
    public class StackTdd {
        public bool IsEmpty { get; set; }
        public List<string> Elements { get; set; }

        public StackTdd() {
            IsEmpty = true;
            Elements = new List<string>();
        }

        public void Push(string elementToPush) {
            Elements.Add(elementToPush);
            IsEmpty = !Elements.Any();
        }

        public string Pop() {
            CheckIfElementListIsNullOrEmpty();
            string elementToRemove = Elements.Last();
            Elements.RemoveAt(Elements.Count - 1);
            IsEmpty = !Elements.Any();
            return elementToRemove;
        }

        public string GetFirstElement() {
            CheckIfElementListIsNullOrEmpty();
            return Elements.First();
        }

        private void CheckIfElementListIsNullOrEmpty() {
            if ((Elements != null) && (!Elements.Any())) {
                throw new StackIsEmptyException("List is null or empty");
            }
        }
    }
}