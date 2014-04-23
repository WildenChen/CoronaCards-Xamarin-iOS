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

in CoronaCards-Communication sample project, Extensions/CoronaCardsViewExtensions.cs can help Xamarin user to use event easy.

----------------------------------------------------------------------------------------
example:
<br>
CoronaView _view = mCoronaCardsViewController.View as CoronaView;
_view.CoronaCards ().OnReceive += HandleOnReceive;
void HandleOnReceive (CoronaView target, NSDictionary e){.....}
 
or 
 
_view.CoronaCards ().OnReceive += (CoronaView target, NSDictionary e) => {};

----------------------------------------------------------------------------------------

