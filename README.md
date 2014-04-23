CoronaCards-Xamarin-iOS
=======================

CoronaCards-Xamarin-iOS

in Xamarin.iOS Projects
iOS Build > General > Additional mtouch arguments:
--gcc_flags="-stdlib=libstdc++"

And in project.csproj 

Change
<br>
\<IPhoneResourcePrefix>Resources\</IPhoneResourcePrefix> 
<br>
to
<br>
\<IPhoneResourcePrefix>Resources;Corona\</IPhoneResourcePrefix>

in CoronaCards-Communication sample project, 
<br>
Extensions/CoronaCardsViewExtensions.cs can help Xamarin user to use event easy.

----------------------------------------------------------------------------------------
example:
<br>
CoronaView _view = mCoronaCardsViewController.View as CoronaView;<br>
_view.CoronaCards ().OnReceive += HandleOnReceive;<br>
void HandleOnReceive (CoronaView target, NSDictionary e){.....}<br>
 <br>
or 
 <br>
_view.CoronaCards ().OnReceive += (CoronaView target, NSDictionary e) => {};<br>

----------------------------------------------------------------------------------------

