using System;

public class BottomNavigation
{

    private string _background;
    private string _video;
    private string _editor;

    public string NavigationWindows
    {
        get
        {
            return string.Format("{0} {1} {2}", this._background, this._video, this._editor);
        }

    }

    public BottomNavigation(string background, string video, string editor){
            this._background = background;
            this._video = video;
            this._editor = editor;
        
    }


    public void CurrentFragment(){
        Console.WriteLine(string.Format("Hi,{0}. Here are you navigation windows", this.NavigationWindows));
    }

}