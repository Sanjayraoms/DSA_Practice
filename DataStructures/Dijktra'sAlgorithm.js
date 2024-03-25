class WeightedGraph{
    constructor(){
        this.adjacencyList = {};
    }
    addVertex(vertex){
        this.adjacencyList[vertex] = [];
    }
    addEdge(vertex1,vertex2,weight){
        this.adjacencyList[vertex1].push({node:vertex2,weight});
        this.adjacencyList[vertex2].push({node:vertex1,weight});
    }
}

var graph = new WeightedGraph();
graph.addVertex("A");
graph.addVertex("B");
graph.addVertex("C");
graph.addEdge("A","B",10);
graph.addEdge("A","C",5);
graph.addEdge("B","C",7);
console.log