public class CompleteRango{
    public CompleteRango(){
        
    } 
    public List<int> build(List<int> list)
    {
        var listInt = new List<int>();
        var maxInt = list.Max();
        listInt = Enumerable.Range(1, maxInt).ToList();                    
        return listInt;
    }
}