using CommunityToolkit.Mvvm.Input;
using ProjectDemo.Model;
using ProjectDemo.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectDemo.ViewModel;

public partial class ArtsViewModel : BaseViewModel
{
    IASCService _ASCService;
    public ObservableCollection<Model.Data> Arts { get; } = new();

    public ArtsViewModel(ASCService ASCService) 
    {
        this._ASCService = ASCService;
        Task.Run(async () => await GetArtsAsync());
    }

    [RelayCommand]
    async Task GoToDetailAsync(Data detail)
    {
        if (detail is null)
            return;
        await Shell.Current.GoToAsync($"{nameof(View.DetailPage)}", true,
             new Dictionary<string, object>
             {
                {"ArtDetail", detail},
             });
    }

    [RelayCommand]
    async Task GetArtsAsync()
    {
        if (IsBusy) return;
        try
        {
            IsBusy = true;
            var arts = await _ASCService.GetArts();
            if (Arts.Count != 0)
                Arts.Clear();

            foreach (var item in arts)
                Arts.Add(item);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error",
                $"Unable to get news: {ex.Message}", "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
}
