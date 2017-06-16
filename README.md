# IE Toolbar for Cognizant Intelligent Test Scripter 
[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/Cognizant-Intelligent-Test-Scripter) [![Google Group](https://img.shields.io/badge/%E2%9C%89-Google%20Group-blue.svg)](https://groups.google.com/forum/#!forum/cognizant-intelligent-test-scripter)

This extension is used to Spy,Heal and Record from Internet Explorer to Cognizant Intelligent Test Scripter

## Requirements

 * Internet Explorer 11
 * .Net 4+
 * Admin rights is needed

Paste the following in cmd prompt to see the installed .Net versions

`dir /b /ad /o-n %systemroot%\Microsoft.NET\Framework\v?.*`

You'll see something like this
```
v4.0.30319 ---If it is not there then you should install .Net 4+
v3.5
v3.0
v2.0.50727
v1.1.4322
v1.0.3705
```

## Installation

Make sure IE is closed.

If you are upgrading to newer version uninstall the old one (Programs and Features -> CognizantITS Toolbar)

Download the [CognizantITS Toolbar](https://github.com/CognizantQAHub/Cognizant-Intelligent-Test-Scripter-IE-Toolbar/releases) and install it.

Open the IE and see the Toolbar at the top. If asked for confirmation accept it.

If the Toolbar is not present even after installation,then 
 * Go to the Folder in which the toolbar is installed
 * You see some .dll files
 * Then run the following command. Make sure `regasm` is available in path

 `regasm /codebase "SearchBar.dll"`

> Regasm will most probably be avaiable in %systemroot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe

## Development / Contribution

Please read [CONTRIBUTING.md](CONTRIBUTING.md) before submitting your pull requests. It also has details on how to setup your development environment.

## Code of Conduct

To provide clarity on what is expected of our members, Cognizant Intelligent Test Scripter has adopted the code of conduct defined by the Contributor Covenant. This document is used across many open source communities and we think it articulates our values well. For more, see the [Code of Conduct](CODE_OF_CONDUCT.md).

## Contact

If you have any queries on Cognizant Intelligent Test Scripter, please post your questions on [Cognizant ITS Google Group](https://groups.google.com/forum/#!forum/cognizant-intelligent-test-scripter).

To ask specific questions on project development, to discuss future improvements or for any other technical detail, please join the [Cognizant ITS chat on Gitter](https://gitter.im/Cognizant-Intelligent-Test-Scripter).

## License

Cognizant Intelligent Test Scripter is licensed under [Apache License, Version 2.0](LICENSE)
