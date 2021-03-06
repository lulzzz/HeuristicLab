#region License Information
/* HeuristicLab
 * Copyright (C) Heuristic and Evolutionary Algorithms Laboratory (HEAL)
 *
 * This file is part of HeuristicLab.
 *
 * HeuristicLab is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * HeuristicLab is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with HeuristicLab. If not, see <http://www.gnu.org/licenses/>.
 */
#endregion

using HeuristicLab.Common;
using HeuristicLab.Core;
using HEAL.Attic;
using HeuristicLab.Problems.DataAnalysis;

namespace HeuristicLab.Algorithms.DataAnalysis {
  /// <summary>
  /// Represents a neural network solution for a classification problem which can be visualized in the GUI.
  /// </summary>
  [Item("NeuralNetworkClassificationSolution", "Represents a neural network solution for a classification problem which can be visualized in the GUI.")]
  [StorableType("7B08B27F-66B6-47C8-946E-51B28F603B43")]
  public sealed class NeuralNetworkClassificationSolution : ClassificationSolution, INeuralNetworkClassificationSolution {

    public new INeuralNetworkModel Model {
      get { return (INeuralNetworkModel)base.Model; }
      set { base.Model = value; }
    }

    [StorableConstructor]
    private NeuralNetworkClassificationSolution(StorableConstructorFlag _) : base(_) { }
    private NeuralNetworkClassificationSolution(NeuralNetworkClassificationSolution original, Cloner cloner)
      : base(original, cloner) {
    }
    public NeuralNetworkClassificationSolution(INeuralNetworkModel nnModel, IClassificationProblemData problemData)
      : base(nnModel, problemData) {
    }

    public override IDeepCloneable Clone(Cloner cloner) {
      return new NeuralNetworkClassificationSolution(this, cloner);
    }

  }
}
