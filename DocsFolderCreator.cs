using System.IO;

namespace DotnetTool.CleanArchSln
{
    public class DocsFolderCreator
    {
        public void Create()
        {
            System.IO.Directory.CreateDirectory("Docs");
            System.IO.Directory.CreateDirectory(@"Docs\ADL");
            using (StreamWriter sw = File.CreateText(@"Docs\ADL\ADR1.md"))
            {
                sw.Write(@"# [ Title ]
                
* Status: 
* Deciders: 
* Date: 

Technical Story: [description | ticket/issue URL]

## Context and Problem Statement

    text

## Decision Drivers

    text

## Considered Options

* option 1
* option 2
* option 3

## Decision Outcome

Chosen option: [option 1], because [justification. e.g., only option, which meets k.o. criterion decision driver | which resolves force force | … | comes out best (see below)].

### Positive Consequences

[e.g., improvement of quality attribute satisfaction, follow-up decisions required, …]
…

### Negative Consequences

[e.g., compromising quality attribute, follow-up decisions required, …]
…

## Pros and Cons of the Options

### [option 1]

 [example | description | pointer to more information | …]

* Good, because [argument a]
* Good, because [argument b]
* Bad, because [argument c]
* …

### [option 2]

[example | description | pointer to more information | …]

* Good, because [argument a]
* Good, because [argument b]
* Bad, because [argument c]
* …

### [option 3]

[example | description | pointer to more information | …]

* Good, because [argument a]
* Good, because [argument b]
* Bad, because [argument c]
* …

## Links

*[Link type] [Link to ADR]
*…");
            }
            System.IO.Directory.CreateDirectory(@"Docs\PostmanTestRequests");
        }
    }
}