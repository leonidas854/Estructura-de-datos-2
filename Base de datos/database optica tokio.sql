PGDMP  9                 
    |         	   db_Optica    17.0    17.0                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false                       1262    24576 	   db_Optica    DATABASE     ~   CREATE DATABASE "db_Optica" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Spain.1252';
    DROP DATABASE "db_Optica";
                     postgres    false            �            1259    32817    controladores    TABLE     �   CREATE TABLE public.controladores (
    id_controlador character varying(30) NOT NULL,
    nombre_controlador character varying(255) NOT NULL,
    descripcion text
);
 !   DROP TABLE public.controladores;
       public         heap r       postgres    false            �            1259    32826    permisos_rol    TABLE     _  CREATE TABLE public.permisos_rol (
    id_rol character varying(30) NOT NULL,
    id_controller character varying(30) NOT NULL,
    permiso character varying(50),
    CONSTRAINT permisos_rol_permiso_check CHECK (((permiso)::text = ANY ((ARRAY['Lectura'::character varying, 'Escritura'::character varying, 'Completo'::character varying])::text[])))
);
     DROP TABLE public.permisos_rol;
       public         heap r       postgres    false            �            1259    32808    roles    TABLE     �   CREATE TABLE public.roles (
    id_rol character varying(30) NOT NULL,
    nombre_rol character varying(255) NOT NULL,
    descripcion text
);
    DROP TABLE public.roles;
       public         heap r       postgres    false            �            1259    32842    usuarios    TABLE     �  CREATE TABLE public.usuarios (
    id_usuario character varying(30) NOT NULL,
    nombre_user character varying(255) NOT NULL,
    apell_paterno character varying(255) NOT NULL,
    apell_materno character varying(255) NOT NULL,
    contrase character varying(255) NOT NULL,
    correo character varying(255),
    id_rol character varying(30),
    fecha_creacion timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    foto bytea
);
    DROP TABLE public.usuarios;
       public         heap r       postgres    false                      0    32817    controladores 
   TABLE DATA           X   COPY public.controladores (id_controlador, nombre_controlador, descripcion) FROM stdin;
    public               postgres    false    218   .                 0    32826    permisos_rol 
   TABLE DATA           F   COPY public.permisos_rol (id_rol, id_controller, permiso) FROM stdin;
    public               postgres    false    219   K                 0    32808    roles 
   TABLE DATA           @   COPY public.roles (id_rol, nombre_rol, descripcion) FROM stdin;
    public               postgres    false    217   h       	          0    32842    usuarios 
   TABLE DATA           �   COPY public.usuarios (id_usuario, nombre_user, apell_paterno, apell_materno, contrase, correo, id_rol, fecha_creacion, foto) FROM stdin;
    public               postgres    false    220   �       i           2606    32825 2   controladores controladores_nombre_controlador_key 
   CONSTRAINT     {   ALTER TABLE ONLY public.controladores
    ADD CONSTRAINT controladores_nombre_controlador_key UNIQUE (nombre_controlador);
 \   ALTER TABLE ONLY public.controladores DROP CONSTRAINT controladores_nombre_controlador_key;
       public                 postgres    false    218            k           2606    32823     controladores controladores_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public.controladores
    ADD CONSTRAINT controladores_pkey PRIMARY KEY (id_controlador);
 J   ALTER TABLE ONLY public.controladores DROP CONSTRAINT controladores_pkey;
       public                 postgres    false    218            m           2606    32831    permisos_rol permisos_rol_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public.permisos_rol
    ADD CONSTRAINT permisos_rol_pkey PRIMARY KEY (id_rol, id_controller);
 H   ALTER TABLE ONLY public.permisos_rol DROP CONSTRAINT permisos_rol_pkey;
       public                 postgres    false    219    219            e           2606    32816    roles roles_nombre_rol_key 
   CONSTRAINT     [   ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_nombre_rol_key UNIQUE (nombre_rol);
 D   ALTER TABLE ONLY public.roles DROP CONSTRAINT roles_nombre_rol_key;
       public                 postgres    false    217            g           2606    32814    roles roles_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (id_rol);
 :   ALTER TABLE ONLY public.roles DROP CONSTRAINT roles_pkey;
       public                 postgres    false    217            o           2606    32851    usuarios usuarios_correo_key 
   CONSTRAINT     Y   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_correo_key UNIQUE (correo);
 F   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_correo_key;
       public                 postgres    false    220            q           2606    32849    usuarios usuarios_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_pkey PRIMARY KEY (id_usuario);
 @   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_pkey;
       public                 postgres    false    220            r           2606    32837 ,   permisos_rol permisos_rol_id_controller_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.permisos_rol
    ADD CONSTRAINT permisos_rol_id_controller_fkey FOREIGN KEY (id_controller) REFERENCES public.controladores(id_controlador);
 V   ALTER TABLE ONLY public.permisos_rol DROP CONSTRAINT permisos_rol_id_controller_fkey;
       public               postgres    false    218    219    4715            s           2606    32832 %   permisos_rol permisos_rol_id_rol_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.permisos_rol
    ADD CONSTRAINT permisos_rol_id_rol_fkey FOREIGN KEY (id_rol) REFERENCES public.roles(id_rol);
 O   ALTER TABLE ONLY public.permisos_rol DROP CONSTRAINT permisos_rol_id_rol_fkey;
       public               postgres    false    217    219    4711            t           2606    32852    usuarios usuarios_id_rol_fkey    FK CONSTRAINT        ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_id_rol_fkey FOREIGN KEY (id_rol) REFERENCES public.roles(id_rol);
 G   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_id_rol_fkey;
       public               postgres    false    220    217    4711                  x������ � �            x������ � �            x������ � �      	      x������ � �     