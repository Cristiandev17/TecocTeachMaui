using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ConceptTest.Models;

public partial class PersonModel
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public bool IsShow { get; set; }


}
