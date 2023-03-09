### Hash dictionary
Erik Isaksson

ein22002

C# has a generic [Dictionary<K,V>](https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx) collection class that implements the [IDictionary<K,V>](https://msdn.microsoft.com/en-us/library/s4ys34ea(v=vs.110).aspx) interface. According to MSDN: "The Dictionary class provides a mapping from a set of keys to a set of values. Each addition to the dictionary consists of a value and its associated key". The focus of this assignment is the use of generics, and the understanding of interfaces and interface inheritance by implementing and using your own class(es).

This assignment consists of two parts:

### Part 1 - creating `HashDictionary<K,V>`

In this part you will create your own class that implements the [IDictionary<K,V>](https://msdn.microsoft.com/en-us/library/s4ys34ea(v=vs.110).aspx) interface. In order to implement the [IDictionary<K,V>](https://msdn.microsoft.com/en-us/library/s4ys34ea(v=vs.110).aspx) interface you must understand and implement the [ICollection<T>](https://msdn.microsoft.com/en-us/library/92t2ye13(v=vs.110).aspx) interface, and the [IEnumerable<T>](https://msdn.microsoft.com/en-us/library/9eekhta0(v=vs.110).aspx) interface. You are free to chose how you want to implement the hashtable. There are various ways it can be implemented, e.g., 

1. hashing + chaining 
2. hashing + linear probing
3. hashing + quadratic probing
4. using some form of dynamic array or list and perform a linear search when looking for values

Of those 4 is probably the most direct, while 1 is probably the most rewarding in terms of knowledge. If you feel you have to fresh up on hashtables see e.g., [Hash table on Wikipedia](https://en.wikipedia.org/wiki/Hash_table). NOTE: you are not allowed to use the C# Dictionary implementation as a delegate as this would make the assignment trivial. You are expected to be able to implement the [IDictionary<K,V>](https://msdn.microsoft.com/en-us/library/s4ys34ea(v=vs.110).aspx) yourselves in some way.

### Part 2 - creating classes for keys

In this part you will a class GeoLocation that represents a location on earth using latitudes and longitudes. Make all the necessary functions and operator overloads to make it possible to use this class as a key for the `HashDictionary<K,V>` class. In particular, ensure that hashing and equality is done using the latitude and longitude and not object identity.

### Testing

To test your implementation use the provided HashtableTester.cs. Add the file to your project and use the testdriver to test your implementation. If `d` contains an instance of your dictionary you can test it using `HashtableTester.TestDriver.Instance.Run(d, 10000);`. Make sure your solution passes all the tests before sending it in; the assignment will be tested using this tester.

### Steps

To complete this assignment follow the steps below.

1. Study the interfaces you have to implement, [IDictionary<K,V>](https://msdn.microsoft.com/en-us/library/s4ys34ea(v=vs.110).aspx) , KeyValuePair<K,V>, [ICollection<T>](https://msdn.microsoft.com/en-us/library/92t2ye13(v=vs.110).aspx), [IEnumerable<T>](https://msdn.microsoft.com/en-us/library/9eekhta0(v=vs.110).aspx), and [IEnumerator<T>](https://msdn.microsoft.com/en-us/library/78dfe2yb(v=vs.110).aspx).
2. Design your solution and discuss your solution with the assistants. The design is relatively straight forward this time, since it, to a large extent, is controlled by the demands of the interfaces.
3. Implement the assignment based on the design. Revise the design if needed - iteration may be necessary.
4. Make sure your solution passes `HashtableTester.TestDriver.Instance.Run(d, 10000);` as this is what we do. We won't grade solutions that do not pass 10000 tests.

### Git and handing in

Ensure that you follow the steps below to avoid issues.

1. push frequent small, well documented updates
2. create a *feedback* branch to work in 
3. always push into the *feeback* branch
4. never push into the *main* branch as this prevents you from handing in properly
5. always include your names and student ids in the README.md file - otherwise we might not be able to attribute your assignment to you
6. when done create a pull request from the *feedback* branch into the *main* branch
7. tag both graders as reviewers


### Hints

- While [IEnumerator<T>](https://msdn.microsoft.com/en-us/library/78dfe2yb(v=vs.110).aspx) demands [IDisposable](https://msdn.microsoft.com/en-us/library/system.idisposable(v=vs.110).aspx) it is ok to leave the `Dispose` method empty - we have not talked about disposing objects. If you are interested you can read about Destructors in the programming guide.
- The [Object](https://msdn.microsoft.com/en-us/library/system.object(v=vs.110).aspx) class provides a [GetHashCode](https://msdn.microsoft.com/en-us/library/system.object.gethashcode(v=vs.110).aspx) method.
- You will need to use the [KeyValuePair<K,V>](https://msdn.microsoft.com/en-us/library/5tbh8a42(v=vs.110).aspx) structure to be compatible with the [IDictionary<K,V>](https://msdn.microsoft.com/en-us/library/s4ys34ea(v=vs.110).aspx) interface.
