////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Martin Bustos @FronkonGames <fronkongames@gmail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of
// the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using UnityEngine;
using FronkonGames.GameWork.Foundation;
using FronkonGames.GameWork.Core;

namespace FronkonGames.GameWork.Modules.SceneModule
{
  /// <summary>
  /// .
  /// </summary>
  public sealed class SceneModuleController : MonoBehaviour
  {
    private SceneModule sceneModule;

    private string[] tooltips =
    {
      "This is the tooltip #1",
      "This is the tooltip #2",
      "This is the tooltip #3",
      "This is the tooltip #4",
    };

    private void OnEnable()
    {
      sceneModule = Game.Instance.GetModule<SceneModule>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sceneBuildIndex"></param>
    public void LoadScene(int sceneBuildIndex)
    {
      if (sceneModule != null && sceneModule.IsLoading == false)
      {
        sceneModule.Title = sceneModule.GetLoadingTranslated().ToLower();
        sceneModule.Tooltip = tooltips.Random();
        sceneModule.Load(sceneBuildIndex);
      }
    }
  }
}