using System.IO;


string text = File.ReadAllText("Ronnie O'Sullivan Fastest 147.m3u8");
var textFile = File.ReadAllLines("Ronnie O'Sullivan Fastest 147.m3u8");

for(int i = 6; i < textFile.Count(); i+=2)
{
    if(i == textFile.Count() - 1)
        break;
    text = text.Replace(i.ToString(), "Ronnie O'Sullivan Fastest 147:" + i.ToString());
}
File.WriteAllText("Ronnie O'Sullivan Fastest 147.m3u8", text);
    