public class HuffmanCompression
{
    private class HuffmanNode : IComparable<HuffmanNode>
    {
        public byte Symbol { get; set; }
        public int Frequency { get; set; }
        public HuffmanNode Left { get; set; }
        public HuffmanNode Right { get; set; }

        public HuffmanNode(byte symbol, int frequency)
        {
            Symbol = symbol;
            Frequency = frequency;
        }

        public HuffmanNode(int frequency, HuffmanNode left, HuffmanNode right)
        {
            Frequency = frequency;
            Left = left;
            Right = right;
        }

        public int CompareTo(HuffmanNode other)
        {
            return Frequency.CompareTo(other.Frequency);
        }
    }

    private class HuffmanTree
    {
        private Dictionary<byte, string> encodingTable = new Dictionary<byte, string>();
        private HuffmanNode root;

        public HuffmanTree(Dictionary<byte, int> frequencies)
        {
            BuildTree(frequencies);
        }

        private void BuildTree(Dictionary<byte, int> frequencies)
        {
            PriorityQueue<HuffmanNode> priorityQueue = new PriorityQueue<HuffmanNode>();

            foreach (var entry in frequencies)
            {
                priorityQueue.Enqueue(new HuffmanNode(entry.Key, entry.Value));
            }

            while (priorityQueue.Count > 1)
            {
                HuffmanNode left = priorityQueue.Dequeue();
                HuffmanNode right = priorityQueue.Dequeue();
                HuffmanNode parent = new HuffmanNode(left.Frequency + right.Frequency, left, right);
                priorityQueue.Enqueue(parent);
            }

            root = priorityQueue.Dequeue();
            GenerateEncodingTable(root, "");
        }

        private void GenerateEncodingTable(HuffmanNode node, string encoding)
        {
            if (node.Left == null && node.Right == null)
            {
                encodingTable[node.Symbol] = encoding;
            }
            else
            {
                GenerateEncodingTable(node.Left, encoding + "0");
                GenerateEncodingTable(node.Right, encoding + "1");
            }
        }

        public byte[] Compress(byte[] data)
        {
            List<bool> compressedData = new List<bool>();

            foreach (byte symbol in data)
            {
                string code = encodingTable[symbol];
                foreach (char bit in code)
                {
                    compressedData.Add(bit == '1');
                }
            }

            int padding = 8 - compressedData.Count % 8;
            for (int i = 0; i < padding; i++)
            {
                compressedData.Add(false);
            }

            byte[] compressedBytes = new byte[compressedData.Count / 8];
            for (int i = 0; i < compressedBytes.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (compressedData[i * 8 + j])
                    {
                        compressedBytes[i] |= (byte)(1 << (7 - j));
                    }
                }
            }

            return compressedBytes;
        }
    }

    public static byte[] Compress(byte[] data)
    {
        Dictionary<byte, int> frequencies = new Dictionary<byte, int>();

        foreach (byte symbol in data)
        {
            if (!frequencies.ContainsKey(symbol))
            {
                frequencies[symbol] = 1;
            }
            else
            {
                frequencies[symbol]++;
            }
        }

        HuffmanTree tree = new HuffmanTree(frequencies);
        return tree.Compress(data);
    }
}