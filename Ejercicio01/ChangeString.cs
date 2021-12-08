public class ChangeString{
    public ChangeString(){

    }
    public int Suma(int num1, int num2)
    {
        return num1 + num2;
    }
    public String build(String caracter){
        var abecedario = new List<char>(){'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o','p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var result = "";
            foreach (var item in caracter.ToCharArray())
            {
                var charAfter = new char();
                if (Char.IsLetter(item))
                {
                    if (char.IsUpper(item))
                    {
                        charAfter = Char.ToUpper(char.ToLower(item)=='z'? 'A':abecedario[abecedario.IndexOf(char.ToLower(item)) + 1]);
                    }
                    else
                    {
                        charAfter = Char.ToLower(char.ToLower(item) == 'z' ? 'a' : abecedario[abecedario.IndexOf(char.ToLower(item)) + 1]);
                    }
                }
                else {

                    charAfter = item;
                }
                result = result + charAfter;
            }
            return result;            
    }
}