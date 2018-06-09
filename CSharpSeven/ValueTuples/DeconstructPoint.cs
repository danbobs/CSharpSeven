namespace CSharpSeven
{
    public class DeconstructPoint
    {

        public void Deconstruct()
        {
            var point = new Point(1, 2, 3);
            var (x, y, z) = point;
            (x,y) = point;
        }

    }

    class Point
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Point(int x, int y, int z) { X = x; Y = y; Z = z}
        // Out params!? WHHHHYYYYYY? Why not return a tuple here? The stupid, IT BURNS!!!
        public void Deconstruct(out int x, out int y, out int z) { x = X; y = Y; z = Z; }
        // apparently for this reason, to allow overloads to allow different number of items in tuple
        public void Deconstruct(out int x, out int y) { x = X; y = Y; }
    }
}
