#version 330 core

in vec3 vertIn;
 
uniform mat4 view;
uniform mat4 proj;
uniform mat4 model;

void main(){
 	mat4 lightSpace = proj * view;
	gl_Position = lightSpace * model * vec4(vertIn, 1);
}