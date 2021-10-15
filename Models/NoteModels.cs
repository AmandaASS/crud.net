namespace crud.Models
{
    public class Note
    {

        private string _author;

        private string _title;

        private string _text;

        public Note(string author, string title,string text){
            this._author = author;
            this._text = text;
            this._title = title;
        }
        
    }
}