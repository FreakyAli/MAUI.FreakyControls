﻿namespace Maui.FreakyControls;

public interface IFreakyAutoCompleteView : IEntry, IDrawableImageView
{
    //string Text { get; set; }
    //Color TextColor { get; set; }
    //string Placeholder { get; set; }
    //Color PlaceholderColor { get; set; }
    string TextMemberPath { get; set; }

    string DisplayMemberPath { get; set; }
    bool IsSuggestionListOpen { get; set; }
    bool UpdateTextOnSelect { get; set; }
    System.Collections.IList ItemsSource { get; set; }
    int Threshold { get; set; }
    bool AllowCopyPaste { get; set; }

    void RaiseSuggestionChosen(FreakyAutoCompleteViewSuggestionChosenEventArgs e);

    void NativeControlTextChanged(FreakyAutoCompleteViewTextChangedEventArgs e);

    void RaiseQuerySubmitted(FreakyAutoCompleteViewQuerySubmittedEventArgs e);
}