# [Hashtable Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.hashtable?view=netframework-4.8)
- Represents a collection of key/value pairs that are organized based on the hash code of the key.

## Creating
- use `Hashtable [name] = new Hashtable();` to create a new hashtable.
    - There are various constructors when you instantiate a hashtable. here are some 
        1. `Hashtable()` instantiates an empty hashtable using the default initial capacity, load factor, hash code provider and comparer
        1. `Hashtable(int capacity)` instantiates the hash table with the defined capacity size.
        1. `Hashtable(int capacity, int load factor)` instantiates the hash table with the defined capacity size and load factor.
            - load factor is between .1 and 1.0. The load factor is the number of keys stored in the hash table divided by the capacity.

## Common Hashtable Methods
1. `.Add(object key, object value);`
1. `.Remove(object key);`
1. `this[key];`
1. `this[key] = [newValue];`
1. `.ContainsKey(object key);`

## Remarks
- A key cannot be `null` but a value can be `null`.
