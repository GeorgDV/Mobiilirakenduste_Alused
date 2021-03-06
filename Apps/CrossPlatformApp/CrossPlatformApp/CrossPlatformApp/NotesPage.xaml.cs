﻿using CrossPlatformApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatformApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotesPage : ContentPage
	{
		public NotesPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            NotesListView.ItemsSource = await App.dbContext.GetNotesAsync();


            //LOCAL NOTES FILE DATABASE
            //var notes = new List<Note>();
            //var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");

            //foreach (var filename in files)
            //{
            //    notes.Add(new Note 
            //    {
            //        Filename = filename,
            //        Text = File.ReadAllText(filename),
            //        Date = File.GetCreationTime(filename),
            //    });
            //}

            //NotesListView.ItemsSource = notes
            //                            .OrderBy(d => d.Date)
            //                            .ToList();
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NoteEntryPage {
                BindingContext = new Note()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NoteEntryPage
                {
                    BindingContext = e.SelectedItem as Note,
                });
            }
        }
    }
}