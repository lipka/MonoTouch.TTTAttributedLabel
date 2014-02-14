XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/TTTAttributedLabel.xcodeproj
TARGET=TTTAttributedLabel

all: libTTTAttributedLabel.a

libTTTAttributedLabel-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libTTTAttributedLabel-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libTTTAttributedLabel.a: libTTTAttributedLabel-i386.a libTTTAttributedLabel-armv7.a
	lipo -create -output $@ $^

clean:
	-rm -rf *.a *.dll build/
