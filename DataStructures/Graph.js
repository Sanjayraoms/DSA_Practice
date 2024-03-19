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
}

var graph = new Graph();
graph.addvertex("Delhi");
graph.addvertex("Dallas");
graph.addvertex("Tokyo");
graph.addvertex("Hongkong");
graph.addEdge("Delhi","Dallas")
graph.addEdge("Delhi","Tokyo")
graph.addEdge("Delhi","Hongkong")
graph.addEdge("Hongkong","Tokyo")
graph.addEdge("Hongkong","Dallas")
console.log();