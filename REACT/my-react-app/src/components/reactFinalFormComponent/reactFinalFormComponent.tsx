import React, { FC } from 'react';
import { reactFinalFormComponentWrapper } from './reactFinalFormComponent.styled';
import { Form, Field } from 'react-final-form';
interface reactFinalFormComponentProps {}

const reactFinalFormComponent: FC<reactFinalFormComponentProps> = () => (
	<div data-testid="reactFinalFormComponent">
		<div className="App">
			{' '}
			<h1>Sign Up</h1>{' '}
			<Form
				onSubmit={async (values) => {
					await new Promise((resolve) => setTimeout(resolve, 500));
					alert(JSON.stringify(values, null, 2));
				}}
			>
				{' '}
				<Field name="firstName" component="input" placeholder="John" />{' '}
				<Field name="lastName" component="input" placeholder="Doe" />{' '}
				<Field name="email" component="input" placeholder="john@acme.com" />{' '}
				<button type="submit">Submit</button>{' '}
			</Form>{' '}
		</div>
	</div>
);

export default reactFinalFormComponent;
