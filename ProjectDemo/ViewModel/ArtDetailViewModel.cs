using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.ViewModel;

[QueryProperty("ArtDetail", "ArtDetail")]
public partial class ArtDetailViewModel : BaseViewModel
{
    public ArtDetailViewModel()
    {
    }
    [ObservableProperty]
    Model.Data artDetail;

}
