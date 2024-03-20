class Graph{
    constructor(){
        this.adjacencyList = {};
    }
    addvertex(vertex){
        if(!this.adjacencyList[vertex])
           this.adjacencyList[vertex] = [];
    }
    addEdge(vertex1,vertex2){
        this.adjacencyList[vertex1].push(vertex2);
        this.adjacencyList[vertex2].push(vertex1);
    }
    removeEdge(vertex1,vertex2){
        this.adjacencyList[vertex1] = this.adjacencyList[vertex1].filter(
            v => v !== vertex2
        );
        this.adjacencyList[vertex2] = this.adjacencyList[vertex2].filter(
            v => v !== vertex1
        );
    }
    removeVertex(vertex){
        let arr1 = this.adjacencyList[vertex];
        for (let index = 0; index < arr1.length; index++) {
            this.removeEdge(arr1[index],vertex);           
        }
        delete this.adjacencyList[vertex];
    }
    recursiveDFS(startVertex){
        var results = [];
        var visited = {};
        var adjacencyList = this.adjacencyList;
        function DFS(vertex) {
            if(!vertex) return null;
            results.push(vertex);
            visited[vertex] = true;
            // for (let index = 0; index < adjacencyList[vertex].length; index++) {
            //     if(!visited[adjacencyList[vertex][index]])
            //        return DFS(adjacencyList[vertex][index]);
            // }
            adjacencyList[vertex].forEach(neighbor => {
                if (!visited[neighbor]) {
                    return DFS(neighbor)
                }
            });
        }
        DFS(startVertex);
        return results;
    }
    iterativeDFS(startVertex){
        const adjacencyList = this.adjacencyList;
        var results = [];
        var visited = {};
        var stack = [];
        stack.push(startVertex);
        while (stack.length > 0) {
            let poppedVertex = stack.pop();
            if (!visited[poppedVertex]) {
                visited[poppedVertex] = true;
                results.push(poppedVertex);
                adjacencyList[poppedVertex].forEach(neighbor => {
                    stack.push(neighbor);
                });
            }
        }
        return results;
    }
}

var graph = new Graph();
graph.addvertex("A");
graph.addvertex("B");
graph.addvertex("C");
graph.addvertex("D");
graph.addvertex("E");
graph.addvertex("F");
graph.addEdge("A","B")
graph.addEdge("A","C")
graph.addEdge("B","D")
graph.addEdge("C","E")
graph.addEdge("D","E")
graph.addEdge("D","F")
graph.addEdge("E","F")
console.log(graph.recursiveDFS("A"))
console.log(graph.iterativeDFS("A"));