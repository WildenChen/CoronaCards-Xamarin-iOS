CoronaCards-Xamarin-iOS
=======================

CoronaCards-Xamarin-iOS

in Xamarin.iOS Projects
iOS Build > General > Additional mtouch arguments:
--gcc_flags="-stdlib=libstdc++"

And in project.csproj 

Change
\<IPhoneResourcePrefix>Resources\</IPhoneResourcePrefix> 

to \<IPhoneResourcePrefix>Resources;Corona\</IPhoneResourcePrefix>

in CoronaCards-Communication sample project, Extensions/CoronaCardsViewExtensions.cs can help Xamarin user to use event easy.

example:
CoronaView _view = mCoronaCardsViewController.View as CoronaView;
_view.CoronaCards ().OnReceive += HandleOnReceive;
void HandleOnReceive (CoronaView target, NSDictionary e){.....}
 
or 
 
_view.CoronaCards ().OnReceive += (CoronaView target, NSDictionary e) => {};



----------------------------------------------------------------------------------------
CoronaCards-Binding 為 CoronaCards 的綁定 project.
在要在要使用 Xamarin.iOS 的專案下，直接引用，或是編譯出 CoronaCards.dll 在專案中使用.

在 Xamarin.iOS 的專案下，需要添加以下設定:
iOS Build > General > Additional mtouch arguments:
--gcc_flags="-stdlib=libstdc++"

另外需要編輯 project.csproj ，把 IPhoneResourcePrefix 標簽裡面的 Resources 改為 Resources;Corona
而 Corona 使用的 *.lua與素材，就可以全都放到 Corona 這資料夾內。

在 CoronaCards-Communication 專案下，有 Extensions/CoronaCardsViewExtensions.cs
引用後，可以不用透過 CoronaViewDelegate 來實踐相關事件，可以直接使用 Event 的方式來 coding.


