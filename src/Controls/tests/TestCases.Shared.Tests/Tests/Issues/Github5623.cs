using NUnit.Framework;
using NUnit.Framework.Legacy;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.TestCases.Tests.Issues;

public class Github5623 : _IssuesUITest
{
	public Github5623(TestDevice testDevice) : base(testDevice)
	{
	}

	public override string Issue => "Button Released not being triggered";

	// [Test]
	// [Category(UITestCategories.CollectionView)]
	// [FailsOnIOS]
	// public void CollectionViewInfiniteScroll()
	// {
	// 	RunningApp.WaitForElement("CollectionView5623");

	// 	var colView = RunningApp.Query("CollectionView5623").Single();

	// 	AppResult[] lastCellResults = null;

	// 	RunningApp.QueryUntilPresent(() =>
	// 	 {
	// 		 RunningApp.DragCoordinates(colView.Rect.CenterX, colView.Rect.Y + colView.Rect.Height - 50, colView.Rect.CenterX, colView.Rect.Y + 5);

	// 		 lastCellResults = RunningApp.Query("99");

	// 		 return lastCellResults;
	// 	 }, 100, 1);

	// 	Assert.IsTrue(lastCellResults?.Any() ?? false);
	// }
}