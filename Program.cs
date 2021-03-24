using System;
using Data;
using DesignPatterns.Behavioral;
using DesignPatterns.Creational;
using DesignPatterns.Structural;
using DesignPatterns.SOLID.SRP;
using logical_exercise.Algorithm;
using logical_exercise.DataStructures;
using logical_exercise.DataStructuresBook;
using logical_exercise.LanguageDotNet;
using Invoice = DesignPatterns.SOLID.SRP.Invoice;

namespace logical_exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int option = 1;
            int i_option = 1;
            int ii_option = 1;
            // YO AMO A MI ESPOSA :) LE VOY A COMPRAR MUCHOS REGALOS :)

            while (option != 0)
            {
                ConsoleUtility.WriteLine("Choose an option based in the next menu");
                ConsoleUtility.WriteLine("1.-Algorithm");
                ConsoleUtility.WriteLine("2.-DataStructures");
                ConsoleUtility.WriteLine("3.-Design Patterns");
                ConsoleUtility.WriteLine("4.-Language DotNet");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ConsoleUtility.WriteLine("Algorithm");
                        ConsoleUtility.WriteLine("1.-Linear Table");
                        ConsoleUtility.WriteLine("2.-Linear Table Append");
                        ConsoleUtility.WriteLine("3.-Linear Table Delete");
                        ConsoleUtility.WriteLine("4.-Linear Table Insert");
                        ConsoleUtility.WriteLine("5.-Linear Table Search");
                        ConsoleUtility.WriteLine("6.-Factorial");
                        ConsoleUtility.WriteLine("7.-Bubble Sort");
                        ConsoleUtility.WriteLine("8.-Heap Sort");
                        ConsoleUtility.WriteLine("9.-Insert Sorting");
                        ConsoleUtility.WriteLine("10.-Merge Sort");
                        ConsoleUtility.WriteLine("11.-Quick Sort");
                        ConsoleUtility.WriteLine("12.-Select Sort");
                        ConsoleUtility.WriteLine("13.-Binary Search");
                        ConsoleUtility.WriteLine("14.-Fibonnacci");
                        ConsoleUtility.WriteLine("15.-Fibonacci with Memoization");
                        i_option = Convert.ToInt32(Console.ReadLine());
                        switch (i_option)
                        {
                            case 1:
                                ConsoleUtility.WriteLine("Running example of Linear Table");
                                LinearTable linearTable = new LinearTable();
                                linearTable.Run();
                                break;
                            case 2:
                                ConsoleUtility.WriteLine("Running example of Linear Table Append");
                                LinearTableAppend linearTableAppend = new LinearTableAppend();
                                linearTableAppend.Run();
                                break;
                            case 3:
                                ConsoleUtility.WriteLine("Running example of Linear Table Delete");
                                LinearTableDelete linearTableDelete = new LinearTableDelete();
                                linearTableDelete.Run();
                                break;
                            case 4:
                                ConsoleUtility.WriteLine("Running example of Linear Table Insert");
                                LinearTableInsert linearTableInsert = new LinearTableInsert();
                                linearTableInsert.Run();
                                break;
                            case 5:
                                ConsoleUtility.WriteLine("Running example of Linear Table Search");
                                LinearTableSearch linearTableSearch = new LinearTableSearch();
                                linearTableSearch.Run();
                                break;
                            case 6:
                                ConsoleUtility.WriteLine("Running example of Factorial");
                                Factorial factorial = new Factorial();
                                factorial.Run();
                                break;
                            case 7:
                                ConsoleUtility.WriteLine("Running example of Bubble Sort");
                                BubbleSort bubbleSort = new BubbleSort();
                                bubbleSort.Run();
                                break;
                            case 8:
                                ConsoleUtility.WriteLine("Running example of HeapSort");
                                HeapSort heapSort = new HeapSort();
                                heapSort.Run();
                                break;
                            case 9:
                                ConsoleUtility.WriteLine("Running example of InsertSorting");
                                InsertSorting insertSorting = new InsertSorting();
                                insertSorting.Run();
                                break;
                            case 10:
                                ConsoleUtility.WriteLine("Running example of Merge Sort");
                                MergeSort mergeSort = new MergeSort();
                                mergeSort.Run();
                                break;
                            case 11:
                                ConsoleUtility.WriteLine("Running example pf Quick Sort");
                                QuickSort quickSort = new QuickSort();
                                quickSort.Run();
                                break;
                            case 12:
                                ConsoleUtility.WriteLine("Running example of Select Sort");
                                SelectSort selectSort = new SelectSort();
                                selectSort.Run();
                                break;
                            case 13:
                                ConsoleUtility.WriteLine("Running example of Binary Search");
                                BinarySearch binarySearch = new BinarySearch();
                                binarySearch.Run();
                                break;
                            case 14:
                                ConsoleUtility.WriteLine("Running example of Fibonnacci");
                                Fibonnacci fibonnacci = new Fibonnacci();
                                fibonnacci.Run();
                                break;
                            case 15:
                                ConsoleUtility.WriteLine("Running example of Fibonnaci with Memoization");
                                FibonacciMemoization fibonacciMemoization = new FibonacciMemoization();
                                fibonacciMemoization.Run();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        ConsoleUtility.WriteLine("Data Structures");
                        ConsoleUtility.WriteLine("1.-Binary Search Tree");
                        ConsoleUtility.WriteLine("2.-Binary Tree");
                        ConsoleUtility.WriteLine("3.-Doubly Linked List");
                        ConsoleUtility.WriteLine("4.-Double Linked List");
                        ConsoleUtility.WriteLine("5.-Hash Table");
                        ConsoleUtility.WriteLine("6.-Linked List");
                        ConsoleUtility.WriteLine("7.-One Way Circular List");
                        ConsoleUtility.WriteLine("8.-Queue");
                        ConsoleUtility.WriteLine("9.-Stack");
                        ConsoleUtility.WriteLine("10.-Two Way Circular List");
                        ConsoleUtility.WriteLine("11.-Unidirectional Linked List");
                        i_option = Convert.ToInt32(Console.ReadLine());
                        ConsoleUtility.WriteLine($"you choose option {i_option}");
                        switch (i_option)
                        {
                            case 1:
                                ConsoleUtility.WriteLine("Running example of Binary Search Tree");
                                BinarySearchTree binarySearchTree = new BinarySearchTree();
                                binarySearchTree.Run();
                                break;
                            case 2:
                                ConsoleUtility.WriteLine("Running example of Binary Tree");
                                BinaryTree binaryTree = new BinaryTree();
                                binaryTree.Run();
                                break;
                            case 3:
                                ConsoleUtility.WriteLine("Running example of DoublyLinkedList");
                                DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
                                doublyLinkedList.Run();
                                break;
                            case 4:
                                ConsoleUtility.WriteLine("Running example of DoubleLinkedList");
                                DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
                                doubleLinkedList.Run();
                                break;
                            case 5:
                                ConsoleUtility.WriteLine("Running example of HashTable");
                                HashTable hashTable = new HashTable();
                                hashTable.Run();
                                break;
                            case 6:
                                ConsoleUtility.WriteLine("Running example of Linked List");
                                LinkedList<int> linkedList = new LinkedList<int>();
                                linkedList.Run();
                                break;
                            case 7:
                                ConsoleUtility.WriteLine("Running example of One Way Circular List");
                                OneWayCircularList circularList = new OneWayCircularList();
                                circularList.Run();
                                break;
                            case 8:
                                ConsoleUtility.WriteLine("Running example of Queue");
                                Queue queue = new Queue();
                                queue.Run();
                                break;
                            case 9:
                                ConsoleUtility.WriteLine("Running example of Stack");
                                Stack stack = new Stack();
                                stack.Run();
                                break;
                            case 10:
                                ConsoleUtility.WriteLine("Running example of Two Way Circular List");
                                TwoWayCircularList twoWay = new TwoWayCircularList();
                                twoWay.Run();
                                break;
                            case 11:
                                ConsoleUtility.WriteLine("Running example fo Unidirectional Linked List");
                                UnidirectionalLinkedList unidirectionalLinkedList = new UnidirectionalLinkedList();
                                unidirectionalLinkedList.Run();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        ConsoleUtility.WriteLine("Design Patterns");
                        ConsoleUtility.WriteLine("1.-Creational");
                        ConsoleUtility.WriteLine("2.-Structural");
                        ConsoleUtility.WriteLine("3.-Behavioral");
                        ConsoleUtility.WriteLine("4.-SOLID Principles");

                        i_option = Convert.ToInt32(Console.ReadLine());
                        ConsoleUtility.WriteLine($"you choose option {i_option}");
                        switch (i_option)
                        {
                            case 1:
                                ConsoleUtility.WriteLine("Example of creational design patterns");
                                ConsoleUtility.WriteLine("1.-Singleton");
                                ConsoleUtility.WriteLine("2.-Factory");
                                ConsoleUtility.WriteLine("3.-Builder");
                                ConsoleUtility.WriteLine("4.-Prototype");
                                ConsoleUtility.WriteLine("5.-Fluent Interface");
                                ConsoleUtility.WriteLine("6.-Factory Method");
                                ConsoleUtility.WriteLine("7.-Abstract Factory");
                                ConsoleUtility.WriteLine("Select one option");
                                ii_option = Convert.ToInt32(Console.ReadLine());
                                switch (ii_option)
                                {
                                    case 1:
                                        ConsoleUtility.WriteLine("Running example of singleton design pattern");
                                        SingletonTest singletonTest = new SingletonTest();
                                        singletonTest.Run();
                                        break;
                                    case 2:
                                        ConsoleUtility.WriteLine("Runnig example of Factory design pattern");
                                        FactoryTest factoryTest = new FactoryTest();
                                        factoryTest.Run();
                                        break;
                                    case 3:
                                        ConsoleUtility.WriteLine("Running example fo Builder Desiogn Pattern");
                                        BuilderTest builderTest = new BuilderTest();
                                        builderTest.Run();
                                        break;
                                    case 4:
                                        ConsoleUtility.WriteLine("Running example of Prototype Design Pattern");
                                        PrototypeTest prototype = new PrototypeTest();
                                        prototype.Run();
                                        break;
                                    case 5:
                                        ConsoleUtility.WriteLine("Running example of Fluent Interface Design Patter");
                                        FluentInterface fluent = new FluentInterface();
                                        fluent.Run();
                                        break;
                                    case 6:
                                        ConsoleUtility.WriteLine("Running example of Factory Method Design Pattern");
                                        FactoryMethodTest factory = new FactoryMethodTest();
                                        factory.Run();
                                        break;
                                    case 7:
                                        ConsoleUtility.WriteLine("Running example of Abstract Factory");
                                        AbstractFactoryTest abstractFactory = new AbstractFactoryTest();
                                        abstractFactory.Run();
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 2:
                                ConsoleUtility.WriteLine("Example of Structural Design Pattern");
                                ConsoleUtility.WriteLine("1.-Adapter");
                                ConsoleUtility.WriteLine("2.-Facade");
                                ConsoleUtility.WriteLine("3.-Decorator");
                                ConsoleUtility.WriteLine("4.-Composite");
                                ConsoleUtility.WriteLine("5.-Proxy");
                                ConsoleUtility.WriteLine("6.-Flyweight");
                                ConsoleUtility.WriteLine("7.-Bridge");
                                ii_option = Convert.ToInt32(Console.ReadLine());
                                switch (ii_option)
                                {
                                    case 1:
                                        ConsoleUtility.WriteLine("Running example of Adapter");
                                        AdapterTest adapter = new AdapterTest();
                                        adapter.Run();
                                        break;
                                    case 2:ConsoleUtility.WriteLine("Running example of Facade");
                                        FacadeTest facade = new FacadeTest();
                                        facade.Run();
                                        break;
                                    case 3:
                                        ConsoleUtility.WriteLine("Running example of Decorator");
                                        DecoratorTest decorator = new DecoratorTest();
                                        decorator.Run();
                                        break;
                                    case 4:
                                        ConsoleUtility.WriteLine("Running example of Composite");
                                        CompositeTest composite = new CompositeTest();
                                        composite.Run();
                                        break;
                                    case 5:
                                        ConsoleUtility.WriteLine("Running example of Proxy");
                                        ProxyTest proxy = new ProxyTest();
                                        proxy.Run();
                                        break;
                                    case 6:
                                        ConsoleUtility.WriteLine("Running example of Flyweight");
                                        FlyweightTest flyweight = new FlyweightTest();
                                        flyweight.Run();
                                        break;
                                    case 7:
                                        ConsoleUtility.WriteLine("Running example of Bridge");
                                        BridgeTest bridge = new BridgeTest();
                                        bridge.Run();
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 3:
                                ConsoleUtility.WriteLine("Example of Behavioral Design Pattern");
                                ConsoleUtility.WriteLine("1.-Chain of Responsability");
                                ConsoleUtility.WriteLine("2.-Command");
                                ConsoleUtility.WriteLine("3.-Observer");
                                ConsoleUtility.WriteLine("4.-Iterator");
                                ConsoleUtility.WriteLine("5.-State");
                                ConsoleUtility.WriteLine("6.-Template Method");
                                ConsoleUtility.WriteLine("7.-Visitor");
                                ConsoleUtility.WriteLine("8.-Strategy");
                                ConsoleUtility.WriteLine("9.-Mediator");
                                ConsoleUtility.WriteLine("10.-Memento");
                                ConsoleUtility.WriteLine("11.-Interpreter");
                                ii_option = Convert.ToInt32(Console.ReadLine());
                                switch (ii_option)
                                {
                                    case 1:
                                        ConsoleUtility.WriteLine("Running example of Change Of Responsability");
                                        ChainOfResponsability chain = new ChainOfResponsability();
                                        chain.Run();
                                        break;
                                    case 2:
                                        ConsoleUtility.WriteLine("Running example of Command");
                                        CommandTest command = new CommandTest();
                                        command.Run();
                                        break;
                                    case 3:
                                        ConsoleUtility.WriteLine("Running example of Observer");
                                        ObserverTest observer = new ObserverTest();
                                        observer.Run();
                                        break;
                                    case 4:
                                        ConsoleUtility.WriteLine("Running example of Iterator");
                                        IteratorTest iterator = new IteratorTest();
                                        iterator.Run();
                                        break;
                                    case 5:
                                        ConsoleUtility.WriteLine("Running example of State");
                                        StateTest state = new StateTest();
                                        state.Run();
                                        break;
                                    case 6:
                                        ConsoleUtility.WriteLine("Running example of Template Method");
                                        TemplateMehodTest templateMehod = new TemplateMehodTest();
                                        templateMehod.Run();
                                        break;
                                    case 7:
                                        ConsoleUtility.WriteLine("Running example of Visitor");
                                        VisitorTest visitor = new VisitorTest();
                                        visitor.Run();
                                        break;
                                    case 8:
                                        ConsoleUtility.WriteLine("Running example of stratgegy");
                                        StrategyTest strategy = new StrategyTest();
                                        strategy.Run();
                                        break;
                                    case 9:
                                        ConsoleUtility.WriteLine("Running example of Mediator");
                                        MediatorTest mediator = new MediatorTest();
                                        mediator.Run();
                                        break;
                                    case 10:
                                        ConsoleUtility.WriteLine("Running example of Memento");
                                        MementoTest memento = new MementoTest();
                                        memento.Run();
                                        break;
                                    case 11:
                                        ConsoleUtility.WriteLine("Running example of Interpreter");
                                        InterpreterTest interpreter = new InterpreterTest();
                                        interpreter.Run();
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 4:
                                ConsoleUtility.WriteLine("Example of SOLID Principles");
                                ConsoleUtility.WriteLine("1.-Single Responsibility Principle");
                                ii_option = Convert.ToInt32(Console.ReadLine());
                                switch(ii_option){
                                    case 1:
                                        ConsoleUtility.WriteLine("Running example of Single Responsibility");
                                        Invoice invoice = new Invoice();
                                        invoice.Run();
                                        break;
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        ConsoleUtility.WriteLine("Language DotNet");
                        ConsoleUtility.WriteLine("1.-Abstract");
                        ConsoleUtility.WriteLine("2.-Action");
                        ConsoleUtility.WriteLine("3.-AsyncAwait");
                        ConsoleUtility.WriteLine("4.-Delegate");
                        ConsoleUtility.WriteLine("5.-Extensions");
                        ConsoleUtility.WriteLine("6.-Func");
                        ConsoleUtility.WriteLine("7.-Generics");
                        ConsoleUtility.WriteLine("8.-Predicate");
                        ConsoleUtility.WriteLine("9.-Lock");
                        ConsoleUtility.WriteLine("10.-Reflection");
                        ConsoleUtility.WriteLine("11.-IOC Implementation");
                        i_option = Convert.ToInt32(Console.ReadLine());
                        switch (i_option)
                        {
                            case 1:
                                ConsoleUtility.WriteLine("Running example of Abstract Class");
                                Square square = new Square();
                                square.Run();
                                break;
                            case 2:
                                ConsoleUtility.WriteLine("Running example of Action");
                                // LanguageDotNet.Action action = new LanguageDotNet.Action();
                                // action.Run();
                                break;
                            case 3:
                                ConsoleUtility.WriteLine("Running example of AsyncAwait");
                                AsyncAwait asyncAwait = new AsyncAwait();
                                asyncAwait.Run();
                                break;
                            case 4:
                                ConsoleUtility.WriteLine("Running example of Delegate");
                                Number number = new Number();
                                number.Run();
                                break;
                            case 5:
                                ConsoleUtility.WriteLine("Running example of Extensions");
                                IntExtensions intExtensions = new IntExtensions();
                                intExtensions.Run();
                                break;
                            case 6:
                                ConsoleUtility.WriteLine("Running example of Func");
                                Func func = new Func();
                                func.Run();
                                break;
                            case 7:
                                ConsoleUtility.WriteLine("Running example of Generics");
                                Generic generic = new Generic();
                                generic.Run();
                                break;
                            case 8:
                                ConsoleUtility.WriteLine("Running example of Predicate");
                                Predicate predicate = new Predicate();
                                predicate.Run();
                                break;
                            case 9:
                                ConsoleUtility.WriteLine("Running example of Lock");
                                LockTest lockTest = new LockTest();
                                lockTest.runTest();
                                break;
                            case 10:
                                ConsoleUtility.WriteLine("Running example of Reflection");
                                Customer customer = new Customer();
                                customer.Run();
                                break;
                            case 11:
                                ConsoleUtility.WriteLine("Running example of IOC Implementation");
                                IOCImplementation.Run();
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        ConsoleUtility.WriteLine("Exit");
                        break;
                }

            }

        }
    }
}