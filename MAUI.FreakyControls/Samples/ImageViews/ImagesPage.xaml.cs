﻿namespace Samples.ImageViews;

public partial class ImagesPage : ContentPage
{
    public ImagesPage()
    {
        InitializeComponent();
        BindingContext = new ImagesViewModel();
    }

    private void FreakySvgImageView_Tapped(object sender, EventArgs e)
    {
    }
}