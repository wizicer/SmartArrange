Feature: ArrangeTest
	In order to avoid silly mistakes
	As a user
	I want to be told the result of smart arrange.

Scenario: Standard example
	Given I have following files in the file system
	| Filename                     |
	| E:\aa\sp1                    |
	| E:\aa\sp-23412.231.txt       |
	| E:\aa\sp-23412.231(1).txt    |
	| E:\aa\sp-23412.231(1)(1).cmd |
	| E:\aa\sp2                    |
	Given I have following files to be arranged
	| Filename                     |
	| E:\aa\sp-23412.231.txt       |
	| E:\aa\sp-23412.231(1).txt    |
	| E:\aa\sp-23412.231(1)(1).cmd |
	When I start smart arrange
	Then the result should be
	| Filename                                 |
	| E:\aa\sp1                                |
	| E:\aa\p-23412.231\sp-23412.231.txt       |
	| E:\aa\p-23412.231\sp-23412.231(1).txt    |
	| E:\aa\p-23412.231\sp-23412.231(1)(1).cmd |
	| E:\aa\sp2                                |
	| E:\aa\p-23412.231\                       |
	| E:\aa\                                   |
	| E:\                                      |

Scenario: chinese example
	Given I have following files in the file system
	| Filename                                                                            |
	| X:\Movies\007系列之23 天幕杀机 Skyfall.2012.BluRay.720p.x264.AC3-WOFEI.mkv                 |
	| X:\Movies\007系列之20 择日再死 Die.Another.Day.2002.BluRay.720p.x264.AC3-WOFEI.mkv         |
	| X:\Movies\007系列之19 黑日危机 The.World.Is.Not.Enough.1999.BluRay.720p.x264.AC3-WOFEI.mkv |
	| X:\Movies\007系列之22 量子危机 Quantum.Of.Solace.2008.BluRay.720p.x264.AC3-WOFEI.mkv       |
	| X:\Movies\007系列之21 皇家赌场 Casino.Royale.2006.BluRay.720p.x264.AC3-WOFEI.mkv           |
	| X:\Movies\007系列之16 杀人执照 Licence.to.Kill.1989.BluRay.720p.x264.AC3-WOFEI.mkv         |
	| X:\Movies\007系列之14 雷霆杀机 A.View.to.a.Kill.1985.BluRay.720p.x264.AC3-WOFEI.mkv        |
	| X:\Movies\007系列之13 八爪女 Octopussy.1983.BluRay.720p.x264.AC3-WOFEI.mkv                |
	| X:\Movies\007系列之15 黎明生机 The.Living.Daylights.1987.BluRay.720p.x264.AC3-WOFEI.mkv    |
	| X:\Movies\007系列之17 黄金眼 GoldenEye.1995.BluRay.720p.x264.AC3-WOFEI.mkv                |
	| X:\Movies\007系列之12 最高机密 For.Your.Eyes.Only.1981.BluRay.720p.x264.AC3-WOFEI.mkv      |
	| X:\Movies\007系列之11 太空城 Moonraker.1979.BluRay.720p.x264.AC3-WOFEI.mkv                |
	| X:\Movies\007系列之10 海底城 The.Spy.Who.Loved.Me.1977.BluRay.720p.x264.AC3-WOFEI.mkv     |
	| X:\Movies\007系列之18 明日帝国 Tomorrow.Never.Dies.1997.BluRay.720p.x264.AC3-WOFEI.mkv     |
	Given I have following files to be arranged
	| Filename                                                                            |
	| X:\Movies\007系列之23 天幕杀机 Skyfall.2012.BluRay.720p.x264.AC3-WOFEI.mkv                 |
	| X:\Movies\007系列之20 择日再死 Die.Another.Day.2002.BluRay.720p.x264.AC3-WOFEI.mkv         |
	| X:\Movies\007系列之19 黑日危机 The.World.Is.Not.Enough.1999.BluRay.720p.x264.AC3-WOFEI.mkv |
	| X:\Movies\007系列之22 量子危机 Quantum.Of.Solace.2008.BluRay.720p.x264.AC3-WOFEI.mkv       |
	| X:\Movies\007系列之21 皇家赌场 Casino.Royale.2006.BluRay.720p.x264.AC3-WOFEI.mkv           |
	| X:\Movies\007系列之16 杀人执照 Licence.to.Kill.1989.BluRay.720p.x264.AC3-WOFEI.mkv         |
	| X:\Movies\007系列之14 雷霆杀机 A.View.to.a.Kill.1985.BluRay.720p.x264.AC3-WOFEI.mkv        |
	| X:\Movies\007系列之13 八爪女 Octopussy.1983.BluRay.720p.x264.AC3-WOFEI.mkv                |
	| X:\Movies\007系列之15 黎明生机 The.Living.Daylights.1987.BluRay.720p.x264.AC3-WOFEI.mkv    |
	| X:\Movies\007系列之17 黄金眼 GoldenEye.1995.BluRay.720p.x264.AC3-WOFEI.mkv                |
	| X:\Movies\007系列之12 最高机密 For.Your.Eyes.Only.1981.BluRay.720p.x264.AC3-WOFEI.mkv      |
	| X:\Movies\007系列之11 太空城 Moonraker.1979.BluRay.720p.x264.AC3-WOFEI.mkv                |
	| X:\Movies\007系列之10 海底城 The.Spy.Who.Loved.Me.1977.BluRay.720p.x264.AC3-WOFEI.mkv     |
	| X:\Movies\007系列之18 明日帝国 Tomorrow.Never.Dies.1997.BluRay.720p.x264.AC3-WOFEI.mkv     |
	When I start smart arrange
	Then the result should be
	| Filename                                                                                                        |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之23 天幕杀机 Skyfall.2012.BluRay.720p.x264.AC3-WOFEI.mkv                 |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之20 择日再死 Die.Another.Day.2002.BluRay.720p.x264.AC3-WOFEI.mkv         |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之19 黑日危机 The.World.Is.Not.Enough.1999.BluRay.720p.x264.AC3-WOFEI.mkv |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之22 量子危机 Quantum.Of.Solace.2008.BluRay.720p.x264.AC3-WOFEI.mkv       |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之21 皇家赌场 Casino.Royale.2006.BluRay.720p.x264.AC3-WOFEI.mkv           |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之16 杀人执照 Licence.to.Kill.1989.BluRay.720p.x264.AC3-WOFEI.mkv         |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之14 雷霆杀机 A.View.to.a.Kill.1985.BluRay.720p.x264.AC3-WOFEI.mkv        |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之13 八爪女 Octopussy.1983.BluRay.720p.x264.AC3-WOFEI.mkv                |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之15 黎明生机 The.Living.Daylights.1987.BluRay.720p.x264.AC3-WOFEI.mkv    |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之17 黄金眼 GoldenEye.1995.BluRay.720p.x264.AC3-WOFEI.mkv                |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之12 最高机密 For.Your.Eyes.Only.1981.BluRay.720p.x264.AC3-WOFEI.mkv      |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之11 太空城 Moonraker.1979.BluRay.720p.x264.AC3-WOFEI.mkv                |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之10 海底城 The.Spy.Who.Loved.Me.1977.BluRay.720p.x264.AC3-WOFEI.mkv     |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\007系列之18 明日帝国 Tomorrow.Never.Dies.1997.BluRay.720p.x264.AC3-WOFEI.mkv     |
	| X:\Movies\.BluRay.720p.x264.AC3-WOFEI\                                                                          |
	| X:\Movies\                                                                                                      |
	| X:\                                                                                                             |
