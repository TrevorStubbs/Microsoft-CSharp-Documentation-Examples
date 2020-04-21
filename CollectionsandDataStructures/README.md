# [Collections and Data Structures](https://docs.microsoft.com/en-us/dotnet/standard/collections/)
- Similar data can often be handled more efficiently when stored and manipulated as a collection.
- Collections can be manipulated (add, remove and modify) the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netframework-4.8) class or the classes in the [System.Collection](https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=netframework-4.8), [system.Collection.Generic](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic?view=netframework-4.8), [System.Collections.Concurrent](https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent?view=netframework-4.8), and/or [System.Collections.immutable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.immutable?view=netcore-3.1) namespaces.
- In C# collections come in a variety of types: Generic, Non-Generic, Concurrent and Immutable
    - Generic:
        - are type-safe at compile time
        - Typically are offer better performance
        - Accept a type parameter when they are constructed
            - Items do not require casting to/from `object` type when added or removed
    - Non-Generic
        - Store items as `objects` therefore require casting.
    - Concurrent
        - provide efficient thread-safe operations
        - Allows for safe and efficient use of multi-threading.
    - Immutable
        - They are just that: immutable
        - Immutable collections are safe from changes

---

## Common collection features
- All collections implement (directly or indirectly) the [`ICollection`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.icollection?view=netframework-4.8) or the [`ICollection<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?view=netframework-4.8) interfaces.
- Common feature for all collectors:
    1. The ability to enumerate through the collection
    1. The ability to copy the collection contents to an array
        - using the `.CopyTo()` method

- Many collection classes contain the following features:
    1. Capacity and Count properties
        - The capacity is the number of elements it *can* contain                
        - The count is the number of elements it *actually* contains
    > Most collections automatically expand in capacity when the current capacity is reached. The memory is reallocated, and the elements are copied from the old collection to the new one. This reduces the code required to use the collection; however, the performance of the collection might be negatively affected. For example, for List<T>, If Count is less than Capacity, adding an item is an O(1) operation. If the capacity needs to be increased to accommodate the new element, adding an item becomes an O(n) operation, where n is Count. The best way to avoid poor performance caused by multiple reallocations is to set the initial capacity to be the estimated size of the collection.<sub>[1](https://docs.microsoft.com/en-us/dotnet/standard/collections/)</sub>
    1. Consistent lower bound
        - All indexed collections in `System.Collections` are 0-indexed
    1. Synchronization for access from multiple threads.
        - *TODO* read more into mutli-threading and `System.Collections.Concurrent`

## Choosing a Collection

I want to... | Generic option | Non-generic option 
--- | --- | ---
Store items as a key/value pair for quick loop-up by key | [`Dictionary<TKey,TValue>`](TODO) | [`Hashtable`](TODO)
Access items by index | [`List<T>`](TODO) | [`Array`](TODO) or [`ArrayList`](TODO)
First-in-first-out (FIFO) | [`Queue<T>`](TODO) | [`Queue`](TODO)
Last-in-first-out (LIFO) | [`Stack<T>`](TODO) | [`Stack`](TODO)
Access items sequentially | [`LinkedList<T>`](TODO) | None
Receive notifications when an item is removed or added to the collection | [`ObservableCollection<T>`](TODO) | None
Sorted Collection | [`SortedList<TKey,Value>`](TODO) | [`SortedList`]
Set for mathematical functions | [`HashSet<T>`](TODO) or [`SortedSet<T>`](TODO)