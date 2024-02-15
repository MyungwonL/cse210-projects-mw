public class Reference {
    private string _book;
    private string _chapter;
    private string _verse1;
    private string _verse2 = "";

    public Reference(string book, string chapter, string verse1) {
        _book = book;
        _chapter = chapter;
        _verse1 = verse1;
    }

    public Reference(string book, string chapter, string verse1, string verse2) {
        _book = book;
        _chapter = chapter;
        _verse1 = verse1;
        _verse2 = verse2;
    }
    
    public string GetBook() {
        return _book;
    }

    public string GetChapter() {
        return _chapter;
    }

    public string GetVerse1() {
        return _verse1;
    }

    public string GetVerse2() {
        return _verse2;
    }


    public void GetRenderedRef() {
        if (_verse2 == "")
        {
            Console.Write($"{_book} {_chapter}:{_verse1} ");
        }

        else if (_verse2 != "")
        {
            Console.Write($"{_book} {_chapter}:{_verse1}-{_verse2} ");
        }
    }
}