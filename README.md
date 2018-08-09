# MahAppsWithAmmyUICaliburn

A simple example of how to use [MahApps.Metro](http://mahapps.com/), [Caliburn.Micro](https://caliburnmicro.com/), and [Ammy](http://www.ammyui.com/) together. 

Based on the [MahApps.Metro.Caliburn.Demo](https://github.com/MahApps/MahApps.Metro/tree/develop/src/MahApps.Metro.Samples/MahApps.Metro.Caliburn.Demo) with the added twist of Ammy instead of XAML.

I cheated slightly but it was with good reason to be able to see how the Ammy code compares to XAML. I used the [XamlToAmmy tool](https://github.com/AmmyUI/AmmyUI/tree/master/tools/XamlToAmmy), which seems slightly buggy trying to convert the whole project, so I converted each file one at a time. 

~~The Caliburn.Micro portion of the demo uses MEF and I'm not sure if I'll create a version without it which is a bit of a moot point really since the exercise was to learn more about Ammy and MahApps, and in particular the Flyouts.~~

__Edit:__ Yeah, I went ahead and did it. I added a project that doesn't use MEF. It was interesting and a great learning opportunity for both Caliburn.Micro and MahApps.Metro. 
