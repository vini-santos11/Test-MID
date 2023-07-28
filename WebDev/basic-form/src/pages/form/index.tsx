import { SubmitHandler, useForm } from "react-hook-form";
import style from "./style.module.css";
import { useState } from "react";

interface IFormInput {
  name: string;
  email: string;
  subject: string;
  message: string;
}

export function Form() {
  //set state to getData
  const [getData, setData] = useState<IFormInput>();

  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm<IFormInput>();

  const onSubmit: SubmitHandler<IFormInput> = (data) => {
    setData(data);
  };

  return (
    <main className={style.Container}>
      <form onSubmit={handleSubmit(onSubmit)}>
        <div className={style.InputWrapper}>
          <label htmlFor="name">
            Name
            <input
              id="name"
              placeholder="Type here"
              {...register("name", {
                required: {
                  value: true,
                  message: "Name is required",
                },
                minLength: {
                  value: 3,
                  message: "Name must be at least 3 characters",
                },
              })}
            />
          </label>
          {errors.name && (
            <span className={style.Error}>{errors.name.message}</span>
          )}
        </div>

        <div className={style.InputWrapper}>
          <label>
            Email
            <input
              placeholder="Type here"
              {...register("email", {
                required: {
                  value: true,
                  message: "Email is required",
                },
                pattern: {
                  value: /^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$/,
                  message: "Invalid email address",
                },
              })}
            />
          </label>
          {errors.email && (
            <span className={style.Error}>{errors.email.message}</span>
          )}
        </div>

        <div className={style.InputWrapper}>
          <label>
            Subject
            <input
              placeholder="Type here"
              {...register("subject", {
                required: {
                  value: true,
                  message: "Subject is required",
                },
              })}
            />
          </label>
          {errors.subject && (
            <span className={style.Error}>{errors.subject.message}</span>
          )}
        </div>

        <div className={style.InputWrapper}>
          <label>
            Message
            <textarea
              placeholder="Type here"
              {...register("message", {
                required: {
                  value: true,
                  message: "Message is required",
                },
                minLength: {
                  value: 10,
                  message: "Message must be at least 10 characters",
                },
              })}
            />
          </label>
          {errors.message && (
            <span className={style.Error}>{errors.message.message}</span>
          )}
        </div>

        <div>
          <button className={style.ButtonSubmit} type="submit">
            Send
          </button>
        </div>
      </form>

      {getData && (
        <div className={style.DataContainer}>
          <p>{getData?.name}</p>
          <p>{getData?.email}</p>
          <p>{getData?.subject}</p>
          <p>{getData?.message}</p>
        </div>
      )}
    </main>
  );
}
