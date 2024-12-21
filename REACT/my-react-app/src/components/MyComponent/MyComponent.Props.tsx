export interface MyComponentProps {
	id?: Number;
}
export interface MyComponentPropsLazy
	extends JSX.IntrinsicAttributes,
		MyComponentProps {
	id?: Number;
}
