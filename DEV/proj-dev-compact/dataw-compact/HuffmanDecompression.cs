public class HuffmanDecompression
{
    private class HuffmanNode
    {
        public byte Symbol { get; set; }
        public HuffmanNode Left { get; set; }
        public HuffmanNode Right { get; set; }

        public HuffmanNode(byte symbol)
        {
            Symbol = symbol;
        }

        public HuffmanNode(HuffmanNode left, HuffmanNode right)
        {
            Left = left;
            Right = right;
        }
    }

    public static byte[] Decompress(byte[] compressedData)
    {
        using (MemoryStream memoryStream = new MemoryStream(compressedData))
        {
            using (BinaryReader reader = new BinaryReader(memoryStream))
            {
                // Reconstrói a árvore de Huffman
                HuffmanNode root = ReconstructHuffmanTree(reader);

                // Descomprime os dados
                List<byte> decompressedData = new List<byte>();
                HuffmanNode currentNode = root;
                int bit;
                while ((bit = reader.Read()) != -1)
                {
                    if (bit == 0)
                        currentNode = currentNode.Left;
                    else
                        currentNode = currentNode.Right;

                    if (currentNode.Left == null && currentNode.Right == null)
                    {
                        decompressedData.Add(currentNode.Symbol);
                        currentNode = root;
                    }
                }

                return decompressedData.ToArray();
            }
        }
    }

    private static HuffmanNode ReconstructHuffmanTree(BinaryReader reader)
    {
        int bit = reader.Read();
        if (bit == 0)
        {
            byte symbol = reader.ReadByte();
            return new HuffmanNode(symbol);
        }
        else
        {
            HuffmanNode left = ReconstructHuffmanTree(reader);
            HuffmanNode right = ReconstructHuffmanTree(reader);
            return new HuffmanNode(left, right);
        }
    }
}