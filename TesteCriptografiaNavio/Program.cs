class Program
{
  static void Main()
  {
    string encryptedMessage = "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";
    string decryptedMessage = DecryptMessage(encryptedMessage);

    Console.WriteLine(decryptedMessage);
  }

  static string DecryptMessage(string encryptedMessage)
  {
    string[] encryptedValues = encryptedMessage.Split(' ');
    string decryptedMessage = "";

    foreach (string value in encryptedValues)
    {
      int decimalValue = Convert.ToInt32(value, 2);
      int decryptedValue = DecryptValue(decimalValue);
      char decryptedCharacters = Convert.ToChar(decryptedValue);
      decryptedMessage += decryptedCharacters;
    }

    return decryptedMessage;
  }

  static int DecryptValue(int value)
  {
    int reverseBytes = value ^ 3;
    int invertedBytes = ((reverseBytes & 0xF0) >> 4) | ((reverseBytes & 0x0F) << 4);
    return invertedBytes;
  }
}
