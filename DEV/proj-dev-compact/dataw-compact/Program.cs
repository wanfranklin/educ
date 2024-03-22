Console.WriteLine("Comprimir");

byte[] originalData = File.ReadAllBytes("input.txt");
byte[] compressedData = HuffmanCompression.Compress(originalData);
File.WriteAllBytes("compressed.dataw", compressedData);

Console.WriteLine("Descomprimir");

byte[] decompressedOriginalData = File.ReadAllBytes("compressed.dataw");
byte[] decompressedData = HuffmanDecompression.Decompress(decompressedOriginalData);
File.WriteAllBytes("decompressed.txt", decompressedData);