using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Models;

abstract public class FiguraModel
{
    public int? Id { get; set; }
    public double? Area { get; set; }

    public FiguraModel()
    { }

    public FiguraModel(int? id, double? area)
    {
        Id = id;
        Area = area;
    }
}
