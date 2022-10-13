namespace StackTest {
    [TestClass]
    public class StackTest {
        public StackTdd stack { get; set; }

        public StackTest() {
            stack = new StackTdd();
        }

        [TestMethod]
        public void NewlyCreatedStackIsEmpty() {
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        [DataRow("assiette sale")]
        public void StackIsNotEmptyAfterPushOneElement(string elementToPush) {
            stack.Push(elementToPush);
            Assert.IsFalse(stack.IsEmpty);
        }

        [TestMethod]
        public void StackThrowCustomExceptionAfterPopWithoutPush() {
            Assert.ThrowsException<StackIsEmptyException>(() => stack.Pop());
        }

        [TestMethod]
        [DataRow("assiette sale")]
        public void StackIsEmptyAfterPushAndPopOneElement(string elementToPush) {
            stack.Push(elementToPush);
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void StackFirstElementIsXAfterPushingX() {
            Assert.ThrowsException<StackIsEmptyException>(() => stack.GetFirstElement());
        }

        [TestMethod]
        [DataRow("assiette sale")]
        public void StackFirstElementIsXAfterPushingX(string elementToPush) {
            stack.Push(elementToPush);
            Assert.Equals(elementToPush, stack.GetFirstElement());
        }

        [TestMethod]
        [DataRow("assiette sale")]
        public void StackPushXAndPopXCorrectlyRemoveX(string elementToPush) {
            stack.Push(elementToPush);
            Assert.AreEqual(elementToPush, stack.Pop());
        }
    }
}