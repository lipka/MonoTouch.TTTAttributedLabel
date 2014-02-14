# MonoTouch.TTTAttributedLabel

MonoTouch bindings to the fabulous [TTTAttributedLabel](https://github.com/mattt/TTTAttributedLabel) library by [@mattt](https://twitter.com/mattt).

## Usage

``` c#
TTTAttributedLabel label = new TTTAttributedLabel ();
label.Text = new NSString ("I love Tink");
label.AddLinkToURL (new NSUrl ("http://tinkapp.com/"), new NSRange (7, 4));

...

class LabelDelegate : TTTAttributedLabelDelegate {
    public override void DidSelectLinkWithURL (TTTAttributedLabel label, NSUrl url)
    {
        Console.WriteLine ("Clicked URL: {0}", url.ToString ());
    }
}

label.Delegate = new LabelDelegate ();
```

Check out more samples on the original [TTTAttributedLabel](https://github.com/mattt/TTTAttributedLabel) page.

## Build

``` sh
$ make
```

Requires `xcodebuild` and `xbuild` to compile.

## Installation

Add `bindings/MonoTouch.TTTAttributedLabel.dll` to your project and you are all set.

## Requirements

MonoTouch.TTTAttributedLabel is tested on iOS7, but should be compatible with the original TTTAttributedLabel requirements.

## TODO

* Better set text API to allow native strings
* Support NSTextCheckingResults
* Remove NSTextCheckingTypes enum

Pull requests welcome!

## Contact

Lukas Lipka

- http://github.com/lipka
- http://twitter.com/lipec
- http://lukaslipka.com

## License

MonoTouch.TTTAttributedLabel is available under the [MIT license](LICENSE). See the LICENSE file for more info.
