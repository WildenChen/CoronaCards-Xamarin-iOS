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
