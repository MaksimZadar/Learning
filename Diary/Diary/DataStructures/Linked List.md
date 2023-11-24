# Overview
A linked list is a list of nodes which contain pointers to the next node in the list. They may also contain pointers to a previous node to allow backward traversal. They are really good if we want to keep adding to a list without needing to allocate new space for it like a traditional array, but they are not as performant when searching for a particular element as you need to access all nodes to find what you're looking for.

### Types
There are 3 main types of linked lists:
- Single Linked
- Double Linked 
- Circular Linked

#### Single Linked
This is just a standard list of nodes that only hold the data and a reference to the next node (or null if it is a tail node)

#### Double Linked
Hold the data and references to the previous and next nodes. Previous node is null if the node is a head node, and next node is null if it is a tail node.

#### Circular Linked
In this setup the last (tail) node points to the start (head) node. It can be either singly or doubly linked as well.

### Operations
#### Insertion
Inserting into the list. For singly linked requires to link the previous node to the new node. Doubly linked link previous to new and new to previous. Circular linked new to start (if inserted at the tail) and link other related nodes.

#### Deletion
Same as insertion but in reverse. Basically transfer the references from the deleted node to the nodes around it.

#### Searching
Traverse the list to find the required value.
### Advantages
- Dynamic size - means we don't need to reallocate and deallocate space when changing the list
- Insertion / Deletion - efficient especially for large lists where you are inserting a lot of data
- Flexible - can be reorganized without taking up more space

### Disadvantages
- Random access - you cannot acces a random index without traversing the list first
- Extra Memory - array only store data, compared to linked lists which store the data and at least 1 pointer if not more

