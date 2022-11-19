using CSharpAdvanced;

SkypeMessage greetting = new SkypeMessage("Hello");
TextMessage goodBye = new TextMessage("Bey-bey");

void MessegeInfo<T>(T text) where T : TextMessage
{
    Console.WriteLine($"Message {text.Text} had been sent!\r\n\r\n\r\n\r\n");
}

MessegeInfo(greetting);
MessegeInfo(goodBye);