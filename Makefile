all:
	$(MAKE) -C library
	cp library/libTTTAttributedLabel.a binding/libTTTAttributedLabel.a
	$(MAKE) -C binding

clean:
	$(MAKE) -C library clean
	$(MAKE) -C binding clean
