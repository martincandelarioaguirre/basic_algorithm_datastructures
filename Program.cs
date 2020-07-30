using logical_exercise.DataStructures;
using logical_exercise.Algorithm;
using logical_exercise.DataStructuresBook;
using DesignPatterns.Creational;
using DesignPatterns.Structural;
using DesignPatterns.Behavioral;
using Data;
using System;

namespace logical_exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Factorial f = new Factorial();
            // f.Run();
            // QuickSort quick = new QuickSort();
            // quick.Run();
            int option = 0;
            int i_option = 0;
            int ii_option = 0;

            Console.WriteLine("Chose an option based in the next menu");
            Console.WriteLine("1.-Algorithm");
            Console.WriteLine("2.-DataStructures");
            Console.WriteLine("3.-Design Patterns");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Algorithm");
                    Console.WriteLine("1.-Linear Table");
                    Console.WriteLine("2.-Linear Table Append");
                    Console.WriteLine("3.-Linear Table Delete");
                    Console.WriteLine("4.-Linear Table Insert");
                    Console.WriteLine("5.-Linear Table Search");
                    i_option = Convert.ToInt32(Console.ReadLine());
                    switch (i_option)
                    {
                        case 1:
                            Console.WriteLine("Running example of Linear Table");
                            LinearTable linearTable = new LinearTable();
                            linearTable.Run();
                        break;
                        case 2:
                            Console.WriteLine("Running example of Linear Table Append");
                            LinearTableAppend linearTableAppend = new LinearTableAppend();
                            linearTableAppend.Run();
                        break;
                        case 3:
                            Console.WriteLine("Running example of Linear Table Delete");
                            LinearTableDelete linearTableDelete = new LinearTableDelete();
                            linearTableDelete.Run();
                        break;
                        case 4:
                            Console.WriteLine("Running example of Linear Table Insert");
                            LinearTableInsert linearTableInsert = new LinearTableInsert();
                            linearTableInsert.Run();
                        break;
                        case 5:
                            Console.WriteLine("Running example of Linear Table Search");
                            LinearTableSearch linearTableSearch = new LinearTableSearch();
                            linearTableSearch.Run();
                        break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Data Structures");
                    i_option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"you choose option {i_option}");
                    switch (i_option)
                    {
                        default:
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Design Patterns");
                    Console.WriteLine("1.-Creational");
                    Console.WriteLine("2.-Structural");
                    Console.WriteLine("3.-Behavioral");

                    i_option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"you choose option {i_option}");
                    switch (i_option)
                    {
                        case 1:
                            Console.WriteLine("Example of creational design patterns");
                            Console.WriteLine("1.-Singleton");
                            Console.WriteLine("2.-Factory");
                            Console.WriteLine("3.-Builder");
                            Console.WriteLine("4.-Prototype");
                            Console.WriteLine("5.-Fluent Interface");
                            Console.WriteLine("6.-Factory Method");
                            Console.WriteLine("7.-Abstract Factory");
                            Console.WriteLine("Select one option");
                            ii_option = Convert.ToInt32(Console.ReadLine());
                            switch (ii_option)
                            {
                                case 1:
                                    Console.WriteLine("Running example of singleton design pattern");
                                    SingletonTest singletonTest = new SingletonTest();
                                    singletonTest.Run();
                                    break;
                                case 2:
                                    Console.WriteLine("Runnig example of Factory design pattern");
                                    FactoryTest factoryTest = new FactoryTest();
                                    factoryTest.Run();
                                    break;
                                case 3:
                                    Console.WriteLine("Running example fo Builder Desiogn Pattern");
                                    BuilderTest builderTest = new BuilderTest();
                                    builderTest.Run();
                                    break;
                                case 4:
                                    Console.WriteLine("Running example of Prototype Design Pattern");
                                    PrototypeTest prototype = new PrototypeTest();
                                    prototype.Run();
                                    break;
                                case 5:
                                    FluentInterface fluent = new FluentInterface();
                                    fluent.Run();
                                    break;
                                case 6:
                                    FactoryMethodTest factory = new FactoryMethodTest();
                                    factory.Run();
                                    break;
                                case 7:
                                    AbstractFactoryTest abstractFactory = new AbstractFactoryTest();
                                    abstractFactory.Run();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Example of Structural Design Pattern");
                            Console.WriteLine("1.-Adapter");
                            Console.WriteLine("2.-Facade");
                            Console.WriteLine("3.-Decorator");
                            Console.WriteLine("4.-Composite");
                            Console.WriteLine("5.-Proxy");
                            Console.WriteLine("6.-Flyweight");
                            Console.WriteLine("7.-Bridge");
                            ii_option = Convert.ToInt32(Console.ReadLine());
                            switch (ii_option)
                            {
                                case 1:
                                    AdapterTest adapter = new AdapterTest();
                                    adapter.Run();
                                    break;
                                case 2:
                                    FacadeTest facade = new FacadeTest();
                                    facade.Run();
                                    break;
                                case 3:
                                    DecoratorTest decorator = new DecoratorTest();
                                    decorator.Run();
                                break;
                                case 4:
                                    CompositeTest composite = new CompositeTest();
                                    composite.Run();
                                break;
                                case 5:
                                    ProxyTest proxy = new ProxyTest();
                                    proxy.Run();
                                break;
                                case 6:
                                    FlyweightTest flyweight = new FlyweightTest();
                                    flyweight.Run();
                                break;
                                case 7:
                                    BridgeTest bridge = new BridgeTest();
                                    bridge.Run();
                                break;
                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Example of Behavioral Design Pattern");
                            Console.WriteLine("1.-Chain of Responsability");
                            Console.WriteLine("2.-Command");
                            Console.WriteLine("3.-Observer");
                            Console.WriteLine("4.-Iterator");
                            Console.WriteLine("5.-State");
                            Console.WriteLine("6.-Template Method");
                            Console.WriteLine("7.-Visitor");
                            Console.WriteLine("8.-Strategy");
                            Console.WriteLine("9.-Mediator");
                            Console.WriteLine("10.-Memento");
                            Console.WriteLine("11.-Interpreter");
                            ii_option = Convert.ToInt32(Console.ReadLine());
                            switch (ii_option)
                            {
                                case 1:
                                    ChainOfResponsability chain = new ChainOfResponsability();
                                    chain.Run();
                                break;
                                case 2:
                                    CommandTest command = new CommandTest();
                                    command.Run();
                                break;
                                case 3:
                                    ObserverTest observer = new ObserverTest();
                                    observer.Run();
                                break;
                                case 4:
                                    IteratorTest iterator = new IteratorTest();
                                    iterator.Run();
                                break;
                                case 5:
                                    StateTest state = new StateTest();
                                    state.Run();
                                break;
                                case 6:
                                    TemplateMehodTest templateMehod = new TemplateMehodTest();
                                    templateMehod.Run();
                                break;
                                case 7:
                                    VisitorTest visitor = new VisitorTest();
                                    visitor.Run();
                                break;
                                case 8:
                                    StrategyTest strategy = new StrategyTest();
                                    strategy.Run();
                                break;
                                case 9:
                                    MediatorTest mediator = new MediatorTest();
                                    mediator.Run();
                                break;
                                case 10:
                                    MementoTest memento = new MementoTest();
                                    memento.Run();
                                break;
                                case 11:
                                    InterpreterTest interpreter = new InterpreterTest();
                                    interpreter.Run();
                                break;
                                default:
                                break;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }














            // HashTable hashTable = new HashTable();
            // hashTable.Run();

            // HeapSort heap = new HeapSort();
            // heap.Run();

            // BinarySearchTree binarySearchTree = new BinarySearchTree();
            // binarySearchTree.Run();

            // QuickSort quickSort = new QuickSort();
            // quickSort.Run();

            // MergeSort mergeSort = new MergeSort();
            // mergeSort.Run();

            // Factorial factorial = new Factorial();
            // factorial.Run();

            // Stack stack = new Stack();
            // stack.Run();

            // Queue queue = new Queue();
            // queue.Run();

            // OneWayCircularList circularList = new OneWayCircularList();
            // circularList.Run();

            // TwoWayCircularList twoWay = new TwoWayCircularList();
            // twoWay.Run();

            // OneWayCircularList circularList = new OneWayCircularList();
            // circularList.Run();

            // DoublyLinkedList doublyLinked = new DoublyLinkedList();
            // doublyLinked.Run();

            // UnidirectionalLinkedList unidirectional = new UnidirectionalLinkedList();
            // unidirectional.Run();

            // BinarySearch binary = new BinarySearch();
            // binary.Run();

            // InsertSorting insert = new InsertSorting();
            // insert.Run();


            // SelectSort selectSort = new SelectSort();
            // selectSort.Run();


            // BubbleSort bubble = new BubbleSort();
            // bubble.Run();

            // LinearTableInsert linearTableInsert = new LinearTableInsert();
            // linearTableInsert.Run();

            // LinearTableDelete linearTableDelete = new LinearTableDelete();
            // linearTableDelete.Run();

            // LinearTable linearTable = new LinearTable();
            // linearTable.Run();

            // LinearTableSearch linearTableSearch = new LinearTableSearch();
            // linearTableSearch.Run();

            // LinearTableAppend linearTableAppend = new LinearTableAppend();
            // linearTableAppend.Run();

            //LinkedList<int> linkedList = new LinkedList<int>();
            // linkedList.InsertFirst(5);
            // linkedList.InsertFirst(4);
            // linkedList.InsertFirst(3);
            // linkedList.InsertFirst(2);
            // linkedList.InsertFirst(1);
            // linkedList.printAllNodes();
            // linkedList.InsertTop(1);
            // linkedList.InsertTop(2);
            // linkedList.InsertTop(3);
            // linkedList.InsertTop(4);
            // linkedList.InsertTop(5);
            // linkedList.printAllNodes();
            // linkedList.ReverseLinkedList();
            // linkedList.printAllNodes();
            // Console.WriteLine($"Data {linkedList.ExistValue(4)}");
            // linkedList.DeleteNodeByKey(4);
            // Console.WriteLine($"Data {linkedList.ExistValue(4)}");
            // linkedList.printAllNodes();
            // linkedList.InsertTop(10);
            // linkedList.printAllNodes();
            // Console.WriteLine($"Total of elements of the linked list {linkedList.GetCount()}");

            // DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            // doubleLinkedList.InsertTop(1);
            // doubleLinkedList.InsertTop(2);
            // doubleLinkedList.InsertTop(3);
            // doubleLinkedList.InsertTop(4);
            // doubleLinkedList.InsertTop(5);
            // doubleLinkedList.printAllNodes();
            // doubleLinkedList.ReverseDoubleLinkedList();
            // doubleLinkedList.printAllNodes();



            // BinaryTree binaryTree = new BinaryTree();

            // binaryTree.Add(1);
            // binaryTree.Add(2);
            // binaryTree.Add(7);
            // binaryTree.Add(3);
            // binaryTree.Add(10);
            // binaryTree.Add(5);
            // binaryTree.Add(8);

            // Node node = binaryTree.Find(5);
            // int depth = binaryTree.GetTreeDepth();
            // Console.WriteLine(depth);

            // Console.WriteLine("PreOrder Traversal:");
            // binaryTree.TraversePreOrder(binaryTree.Root);
            // Console.WriteLine();

            // Console.WriteLine("InOrder Traversal:");
            // binaryTree.TraverseInOrder(binaryTree.Root);
            // Console.WriteLine();

            // Console.WriteLine("PostOrder Traversal:");
            // binaryTree.TraversePostOrder(binaryTree.Root);
            // Console.WriteLine();

            // binaryTree.Remove(7);
            // binaryTree.Remove(8);

            // Console.WriteLine("PreOrder Traversal After Removing Operation:");
            // binaryTree.TraversePreOrder(binaryTree.Root);
            // Console.WriteLine();

            // Console.ReadLine();
        }
    }
}
