Goal(s) :
---------
- Check if a factory IOC windsor castle has to be explicitly registered or not
- Check if the factory IOC windsor castle does release the components created by a factory (Func<IXXX>)
https://github.com/castleproject/Windsor/blob/master/docs/typed-factory-facility-delegate-based.md

Explanations :
--------------
The use of a factory using IOC to avoid Service Locator pattern

Conclusion :
------------
- No : a factory IOC windsor castle does NOT have to be explicitly registered. But you need to call the following code :
     container.AddFacility<TypedFactoryFacility>();
- Yes, a component created by a factory IOC windsor castle release the component without having to call the release method on the container