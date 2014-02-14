BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
VERSION=1.8.1

all: MonoTouch.TTTAttributedLabel.dll

MonoTouch.TTTAttributedLabel.dll: Makefile ApiDefinition.cs StructsAndEnums.cs libTTTAttributedLabel.a
	$(MONOXBUILD) /p:Configuration=Release MonoTouch.TTTAttributedLabel.csproj
	cp bin/Release/MonoTouch.TTTAttributedLabel.dll MonoTouch.TTTAttributedLabel.dll

clean:
	-rm -rf list ios *.dll *.zip *.mdb *.sln bin/ obj/
