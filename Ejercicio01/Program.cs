Console.WriteLine("Hello, World!");
ChangeString asd = new ChangeString();
String var1 = asd.build("123 abcd*3");
Console.WriteLine(var1);

CompleteRango asd2 = new CompleteRango();

var listInt2 = new List<int>();

int[] valores = {4,2,9};
var listInt = new List<int>(valores);

listInt2 = asd2.build(listInt);
foreach (var item in listInt2){
    Console.WriteLine(item);
}